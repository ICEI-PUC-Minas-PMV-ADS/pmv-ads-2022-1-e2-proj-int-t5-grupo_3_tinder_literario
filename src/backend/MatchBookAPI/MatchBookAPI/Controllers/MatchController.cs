using MatchBookAPI.Seachers;
using MatchBookAPI.Utils;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Npgsql;
using System;
using System.Data;
using System.Globalization;

namespace MatchBookAPI.Controllers
{
    public class MatchController : ControllerBase
    {

        private readonly IConfiguration _configuration;


        public MatchController(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        [Route("api/v1/criar-match")]
        [HttpPost]
        public JsonResult CriarMatch([FromBody] MatchForm matchForm)
        {
            int statusCode = 0;
            Mensagem mensagens = new Mensagem();
            mensagens.status = false;

            try
            {
                string query = @"insert into match_usuario (id,id_usuario_remetente,id_usuario_destinatario,id_lista) values (@id,@id_usuario_remetente,@id_usuario_destinatario,@id_lista) ";

                DataTable table = new DataTable();
                string sqlDataSource = _configuration.GetConnectionString("DbConnection");
                NpgsqlDataReader myReader;
                using (NpgsqlConnection myCon = new NpgsqlConnection(sqlDataSource))
                {
                    myCon.Open();

                    using (NpgsqlCommand myCommand = new NpgsqlCommand(query, myCon))
                    {
                        Guid uuid = Guid.NewGuid();

                        myCommand.Parameters.AddWithValue("@id", uuid.ToString());
                        myCommand.Parameters.AddWithValue("@id_usuario_remetente", matchForm.idUsuarioRemetente);
                        myCommand.Parameters.AddWithValue("@id_usuario_destinatario", matchForm.idUsuarioDestinatario);
                        myCommand.Parameters.AddWithValue("@id_lista", matchForm.idLista);

                        myReader = myCommand.ExecuteReader();
                        table.Load(myReader);

                        myReader.Close();
                        myCon.Close();

                    }
                }
                mensagens.status = true;
                statusCode = 202;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                statusCode = 500;
            }

            Guid newUuid = Guid.NewGuid();

            mensagens.horarioCriacao = DateTime.UtcNow.AddHours(-3).ToString("yyyy-MM-dd HH:mm:ss.fffffff", CultureInfo.InvariantCulture);
            mensagens.id = newUuid.ToString();

            JsonResult response = new JsonResult(mensagens);
            response.StatusCode = statusCode;
            return response;
        }
    }
}
