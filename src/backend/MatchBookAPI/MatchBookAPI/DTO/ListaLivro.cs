using MatchBookAPI.Models;
using System.Collections.Generic;

namespace MatchBookAPI.DTO
{
    public class ListaLivro
    {
        public string idUsuario { get; set; }
        public string id { get; set; }
        
        public string descricao { get; set; }
        public string nome { get; set; }
        public string dataAtualizacao { get; set; }
        public string dataCriacao { get; set; }
       
        public List<Livro> livroList { get; set; }
    }
}
