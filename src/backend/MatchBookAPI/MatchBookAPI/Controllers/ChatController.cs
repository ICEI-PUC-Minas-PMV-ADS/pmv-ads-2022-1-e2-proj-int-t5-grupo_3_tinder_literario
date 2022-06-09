using MatchBookAPI.DTO;
using MatchBookAPI.Seachers;
using MatchBookAPI.Utils;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;

namespace MatchBookAPI.Controllers
{
    public class ChatController : ControllerBase
    {

        private readonly IConfiguration _configuration;


        public ChatController(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        [Route("api/v1/envia-mensagem")]
        [HttpPost]
        public JsonResult EnviaMensagem([FromBody] MensagemForm form)
        {
            int statusCode = 0;

            Mensagem mensagens = new Mensagem();
            mensagens.status = false;
            try
            {
                string query = @"insert into historico_chat (id, destinatario, remetente, horario_criacao, msg) values (@id, @destinatario, @remetente, CAST(@horario_criacao AS TIMESTAMP), @msg ) ";

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
                        myCommand.Parameters.AddWithValue("@destinatario", form.destinatario);
                        myCommand.Parameters.AddWithValue("@remetente", form.remetente);
                        myCommand.Parameters.AddWithValue("@horario_criacao", DateTime.UtcNow.ToString("yyyy-MM-ddTHH:mm:ss", CultureInfo.InvariantCulture));
                        myCommand.Parameters.AddWithValue("@msg", form.mensagem);

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


        [Route("api/v1/mensagem")]
        [HttpGet]
        public List<object> getAllMessages([FromQuery(Name = "idUsuario")] string idUsuario)
        {

            String query = " with phsc as ( select id,destinatario,remetente, horario_criacao, msg FROM public.historico_chat where remetente = " +
                "'" +
                idUsuario +
                "'" +
                " or destinatario = '@idUsuario' order by horario_criacao) select distinct u.id, u.nome, '[' || STRING_AGG( '{' || '\"id\":\"' || phc.id || '\",' || '\"destinatario\":\"' || phc.destinatario || '\",' || '\"remetente\":\"' || phc.remetente || '\",' || '\"horarioCriacao\":\"' ||  phc.horario_criacao - interval '3 hour'  || '\",' || '\"msg\":\"' || phc.msg || '\"}',',' ) || ']' as todas_mensagens FROM phsc phc left join public.usuario u on phc.destinatario = u.id OR phc.remetente  = u.id where u.id not in ('" +
                idUsuario +
                "') GROUP BY 1,2 ";

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
                Contatos contatos = new Contatos();

                contatos.id = dr["id"].ToString();
                contatos.nome = dr["nome"].ToString();


                List<HistoricoChat> historicoChats = JsonConvert.DeserializeObject<List<HistoricoChat>>(dr["todas_mensagens"].ToString());


                contatos.list = historicoChats;

                objectList.Add(contatos);
            }


            return objectList;
        }



    }
}
