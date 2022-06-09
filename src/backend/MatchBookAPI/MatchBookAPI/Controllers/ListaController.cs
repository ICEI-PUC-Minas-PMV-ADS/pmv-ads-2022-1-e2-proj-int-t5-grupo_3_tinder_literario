using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Npgsql;
using System.Data;
using MatchBookAPI.Models;
using MatchBookAPI.Seachers;
using System;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using System.Globalization;
using Google.Apis.Auth.OAuth2;
using Google.Apis.Gmail.v1;
using Google.Apis.Services;
using Google.Apis.Util;
using System.Threading;
using Facebook;
using Microsoft.AspNetCore.Authentication.OAuth;
using System.Threading.Tasks;
using System.Diagnostics;
using Microsoft.Owin.Security.Facebook;
using Microsoft.AspNetCore.Server.HttpSys;
using MatchBookAPI.Utils;
using MatchBookAPI.DTO;

namespace MatchBookAPI.Controllers
{
    [ApiController]
    public class ListaController : ControllerBase
    {

        private readonly IConfiguration _configuration;

        public ListaController(IConfiguration configuration)
        {
                _configuration = configuration;
        }

        [Route("api/v1/criar-lista")]
        [HttpPost]
        public JsonResult CriarLista(Lista form)
        {
            int statusCode = 0;
            CadastroStatus cadastroStatus = null;
            string idLista = Guid.NewGuid().ToString();

            try
            {
                string query = @"
                insert into lista (id,  id_usuario, nome, descricao, data_criacao) 
                values (@id, @id_usuario, @nome, @descricao, CAST(@data_criacao AS DATE))
";

                DataTable table = new DataTable();
                string sqlDataSource = _configuration.GetConnectionString("DbConnection");
                NpgsqlDataReader myReader;
                using (NpgsqlConnection myCon = new NpgsqlConnection(sqlDataSource))
                {
                    myCon.Open();

                    using (NpgsqlCommand myCommand = new NpgsqlCommand(query, myCon))
                    {
                        myCommand.Parameters.AddWithValue("@id", idLista);
                        myCommand.Parameters.AddWithValue("@id_usuario", form.idUsuario);
                        myCommand.Parameters.AddWithValue("@nome", form.nome);
                        myCommand.Parameters.AddWithValue("@descricao", form.descricao);
                        myCommand.Parameters.AddWithValue("@data_criacao", DateTime.UtcNow.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture));
                        myReader = myCommand.ExecuteReader();
                        table.Load(myReader);
                        myReader.Close();
                        myCon.Close();

                    }
                }

                query = @"
                    insert into livro_lista (id,id_livro, id_lista) 
                    values (@id,CAST(@id_livro AS int4), @id_lista) ";

                form.livroList.ForEach(x =>
                {
                    using (NpgsqlConnection myCon = new NpgsqlConnection(sqlDataSource))
                    {
                        myCon.Open();

                        using (NpgsqlCommand myCommand = new NpgsqlCommand(query, myCon))
                        {
                            Guid uuid = Guid.NewGuid();

                            myCommand.Parameters.AddWithValue("@id", Guid.NewGuid().ToString());
                            myCommand.Parameters.AddWithValue("@id_livro", x.id);
                            myCommand.Parameters.AddWithValue("@id_lista", idLista);
                            myReader = myCommand.ExecuteReader();
                            table.Load(myReader);
                            myReader.Close();
                            myCon.Close();

                        }
                    }

                });
                statusCode = 202;
                cadastroStatus = new CadastroStatus("Inserção feita com sucesso!", DateTime.UtcNow.AddHours(-3).ToString("yyyy-MM-dd HH:mm:ss.fffffff", CultureInfo.InvariantCulture), true);

            }
            catch (Exception ex)
            {
                statusCode = 500;
                Console.WriteLine(ex.Message);
                cadastroStatus = new CadastroStatus("Erro na hora de realizar inserção!", DateTime.UtcNow.AddHours(-3).ToString("yyyy-MM-dd HH:mm:ss.fffffff", CultureInfo.InvariantCulture), false);
            }
            JsonResult response = new JsonResult(cadastroStatus);
            response.StatusCode = statusCode;

            return response;
        }

        [Route("api/v1/minha-lista")]
        [HttpGet]
        public List<object> findAllUsuario([FromQuery(Name = "idUsuario")] string idUsuario)
        {
            String query = "SELECT lv.id, lv.id_usuario, lv.nome, lv.data_criacao, lv.data_atualizacao, lv.descricao, '[' || STRING_AGG( '{' || '\"id\":\"' || li.id || '\",' || '\"titulo\":\"' || li.titulo || '\",' || '\"autor\":\"' || li.autor || '\",' || '\"ano_publicacao\":\"' || li.ano_publicacao || '\",' || '\"sinopse\":\"' || REPLACE(li.sinopse, '\"', '') || '\",' || '\"edicao\":\"' || li.edicao || '\",' || '\"editora\":\"' || li.editora || '\",' || '\"isbn\":\"' || li.isbn || '\",' || '\"img_link\":\"' || li.img_link || '\",' || '\"categoria\":\"' || li.categoria || '\"' || '}',',' ) || ']' as livro_list  FROM public.lista lv  LEFT JOIN livro_lista ll on ll.id_lista = lv.id LEFT JOIN public.livro li on ll.id_livro = li.id WHERE 1=1 ";
            if (idUsuario != null)
            {
                query += " AND lv.id_usuario  IN ('" + idUsuario + "') ";
            }

            query += " GROUP BY 1,2,3,4,5,6";
            query += " ORDER BY 4 DESC,1 DESC";

            DataTable table = new DataTable();

            string sqlDataSource = _configuration.GetConnectionString("DbConnection");
            NpgsqlDataReader myReader;

            using (NpgsqlConnection myCon = new NpgsqlConnection(sqlDataSource))
            {
                myCon.Open();
                using (NpgsqlCommand myCommand = new NpgsqlCommand(query, myCon))
                {

                    myReader = myCommand.ExecuteReader();
                    table.Load(myReader);

                    myReader.Close();
                    myCon.Close();
                }
            }


            List<object> objectList = new List<object>();

            foreach (DataRow dr in table.Rows)
            {
                ListaLivro list = new ListaLivro();

                list.id = dr["id"].ToString();
                list.dataCriacao = dr["data_criacao"].ToString();
                list.dataAtualizacao = dr["data_atualizacao"].ToString();
                list.idUsuario = dr["id_usuario"].ToString();
                list.descricao = dr["descricao"].ToString();
                list.nome = dr["nome"].ToString();

                List<Livro> livro = JsonConvert.DeserializeObject<List<Livro>>(dr["livro_list"].ToString());
                list.livroList = livro;

                objectList.Add(list);
            }


            return objectList;
        }


        [Route("api/v1/lista/sort")]
        [HttpGet]
        public List<object> findSorted([FromQuery(Name = "idUsuario")] string idUsuario)
        {

            String query = "SELECT lv.id, lv.id_usuario, lv.nome, lv.data_criacao, lv.data_atualizacao, lv.descricao, '[' || STRING_AGG( '{' || '\"id\":\"' || li.id || '\",' || '\"titulo\":\"' || li.titulo || '\",' || '\"autor\":\"' || li.autor || '\",' || '\"ano_publicacao\":\"' || li.ano_publicacao || '\",' || '\"sinopse\":\"' || REPLACE(li.sinopse, '\"', '') || '\",' || '\"edicao\":\"' || li.edicao || '\",' || '\"editora\":\"' || li.editora || '\",' || '\"isbn\":\"' || li.isbn || '\",' || '\"img_link\":\"' || li.img_link || '\",' || '\"categoria\":\"' || li.categoria || '\"' || '}',',' ) || ']' as livro_list  FROM public.lista lv  LEFT JOIN livro_lista ll on ll.id_lista = lv.id LEFT JOIN public.livro li on ll.id_livro = li.id WHERE 1=1 ";
            if (idUsuario != null)
            {
                query += " AND lv.id_usuario NOT IN ('" + idUsuario + "') ";
            }

            query += " GROUP BY 1,2,3,4,5,6";
            query += " ORDER BY 4 DESC,1 DESC";

            DataTable table = new DataTable();

            string sqlDataSource = _configuration.GetConnectionString("DbConnection");
            NpgsqlDataReader myReader;

            using (NpgsqlConnection myCon = new NpgsqlConnection(sqlDataSource))
            {
                myCon.Open();
                using (NpgsqlCommand myCommand = new NpgsqlCommand(query, myCon))
                {

                    myReader = myCommand.ExecuteReader();
                    table.Load(myReader);

                    myReader.Close();
                    myCon.Close();
                }
            }


            List<object> objectList = new List<object>();

            foreach (DataRow dr in table.Rows)
            {
                ListaLivro list = new ListaLivro();

                list.id = dr["id"].ToString();
                list.dataCriacao = dr["data_criacao"].ToString();
                list.dataAtualizacao = dr["data_atualizacao"].ToString();
                list.idUsuario = dr["id_usuario"].ToString();
                list.nome = dr["nome"].ToString();
                list.descricao = dr["descricao"].ToString();
                list.id = dr["id"].ToString();

                List<Livro> livro = JsonConvert.DeserializeObject<List<Livro>>(dr["livro_list"].ToString());
                list.livroList = livro;

                objectList.Add(list);
            }


            return objectList;
        }

    }


}
