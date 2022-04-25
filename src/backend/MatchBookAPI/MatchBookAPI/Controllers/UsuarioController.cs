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

namespace MatchBookAPI.Controllers
{
    [ApiController]
    public class UsuarioController : ControllerBase
    {

        private readonly IConfiguration _configuration;


        public UsuarioController(IConfiguration configuration)
        {
                _configuration = configuration;
        }

        [Route("api/v1/criar-usuario")]
        [HttpPost]
        public JsonResult CriarUsuario(Usuario usuarioModel)
        {
            string query = @"
                insert into Usuario (id,nome,documento,permissao,email,senha,celular) 
                values (@id,@nome,@documento,@permissao,@email,@senha,@celular) 
            ";

            DataTable table = new DataTable();
            string sqlDataSource = _configuration.GetConnectionString("DbConnection");
            NpgsqlDataReader myReader;
            using (NpgsqlConnection myCon = new NpgsqlConnection(sqlDataSource))
            {
                myCon.Open();

                usuarioModel.senha = BCrypt.Net.BCrypt.HashPassword(usuarioModel.senha);
                using (NpgsqlCommand myCommand = new NpgsqlCommand(query, myCon))
                {
                    Guid uuid = Guid.NewGuid();

                    myCommand.Parameters.AddWithValue("@id", uuid.ToString());
                    myCommand.Parameters.AddWithValue("@nome", usuarioModel.nome);
                    myCommand.Parameters.AddWithValue("@documento", usuarioModel.documento);
                    myCommand.Parameters.AddWithValue("@permissao", usuarioModel.permissao);
                    myCommand.Parameters.AddWithValue("@email", usuarioModel.email);
                    myCommand.Parameters.AddWithValue("@senha", usuarioModel.senha);
                    myCommand.Parameters.AddWithValue("@celular", usuarioModel.celular);

                    myReader = myCommand.ExecuteReader();
                    table.Load(myReader);

                    myReader.Close();
                    myCon.Close();

                }
            }

            JsonResult finded = new JsonResult(table);
            finded.StatusCode = 202;

            return new JsonResult("Usuario Criado com sucesso!");
        }

        [Route("api/v1/autentica-usuario")]
        [HttpPost]
        public JsonResult verificarLogin(LoginSeacher searcher)
        {
            string query = "SELECT usr.nome, usr.senha FROM public.usuario usr ";

            query += " WHERE usr.nome = '" + searcher.nome + "'";

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


            LoginSeacher findedLogin = new LoginSeacher();

            for (int i = 0; i < table.Rows.Count; i++)
            {
                findedLogin.nome = table.Rows[i]["nome"].ToString();
                findedLogin.senha = table.Rows[i]["senha"].ToString();
            }



            if (findedLogin.nome == null)
            {
                return new JsonResult("Usuario ou Senha incorreto!");
            }

            if (BCrypt.Net.BCrypt.Verify(searcher.senha, findedLogin.senha))
            {
                // Futuramente retornar o token
                return new JsonResult("Usuario autenticado com sucesso!");
            }
            else
            {
                return new JsonResult("Usuario ou Senha incorreto!");
            }



            return new JsonResult(table);

        }



    }
}
