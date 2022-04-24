using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Npgsql;
using System.Data;

namespace MatchBookAPI.Repository
{
    public class LivroRepository
    {

        private readonly IConfiguration _configuration;

        public LivroRepository(IConfiguration configuration)
        {
            _configuration = configuration;
        }


        public DataTable findAll()
        {
            string query = "SELECT id, titulo, autor, ano_publicacao, sinopse, edicao, editora, isbn, img_link FROM public.livro";

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
            return table;
        }

    }
}
