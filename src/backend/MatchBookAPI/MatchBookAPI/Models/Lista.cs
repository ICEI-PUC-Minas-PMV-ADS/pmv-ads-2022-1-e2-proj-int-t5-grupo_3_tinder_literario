using MatchBookAPI.DTO;
using NodaTime;
using System.Collections.Generic;

namespace MatchBookAPI.Models
{
    public class Lista
    {
        public int id { get; set; }
        public string idUsuario { get; set; }
        public string nome { get; set; }
        public List<LivroFlat> livroList { get; set; }

    }
}
