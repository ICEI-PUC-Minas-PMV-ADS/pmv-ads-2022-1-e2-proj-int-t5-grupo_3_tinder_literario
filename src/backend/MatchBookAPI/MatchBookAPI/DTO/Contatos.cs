using MatchBookAPI.Utils;
using System.Collections.Generic;

namespace MatchBookAPI.DTO
{
    public class Contatos
    {
        public string id { get; set; }
        public string nome { get; set; }

        public List<HistoricoChat> list { get; set; }
    }
}
