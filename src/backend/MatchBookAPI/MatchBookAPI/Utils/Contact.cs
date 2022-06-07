using System.Collections.Generic;

namespace MatchBookAPI.Utils
{
    public class Conctact
    {
        string id { get; set; }
        string nome { get; set; }  

        List<HistoricoChat> list { get; set; }
    }
}
