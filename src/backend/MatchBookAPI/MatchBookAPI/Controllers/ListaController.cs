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
                insert into lista (id,id_usuario,nome, data_criacao) 
                values (@id, @id_usuario, @nome, CAST(@data_criacao AS DATE))
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


        [Route("api/v1/verifica-email")]
        [HttpGet]
        public JsonResult VerificarEmail([FromQuery(Name = "email")] string email)
        {
            if (email is null)
            {
                throw new ArgumentNullException(nameof(email));
            }

            string query = "SELECT usr.email, usr.id FROM public.usuario usr ";

            query += " WHERE usr.email = '" + email + "'";

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


            VerificaEmail findedLogin = new VerificaEmail();

            findedLogin.id = "";
            findedLogin.email = "";
            findedLogin.existente = false;


            for (int i = 0; i < table.Rows.Count; i++)
            {
                findedLogin.id = table.Rows[i]["id"].ToString();
                findedLogin.email = table.Rows[i]["email"].ToString(); 
                findedLogin.existente = true;
            }
            return new JsonResult(findedLogin);
        }



    }
}
