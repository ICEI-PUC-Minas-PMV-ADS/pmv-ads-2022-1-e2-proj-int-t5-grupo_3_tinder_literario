using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Npgsql;
using System.Data;

namespace MatchBookAPI.Controllers
{
    [Route("api/v1/livro")]
    [ApiController]
    public class LivroController : ControllerBase
    {

        private readonly IConfiguration _configuration;


        public LivroController(IConfiguration configuration)
        {
                _configuration = configuration;
        }

        [HttpGet]
        public JsonResult findAllLivros()
        {
            string query = "SELECT lv.id, lv.titulo, lv.autor, lv.ano_publicacao, lv.sinopse, lv.edicao, lv.editora, lv.isbn, lv.img_link FROM public.livro lv";

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
            return new JsonResult(table);
        }
        





    }
}
