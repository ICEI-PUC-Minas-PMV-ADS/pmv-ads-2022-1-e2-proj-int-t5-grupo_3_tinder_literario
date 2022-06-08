using MatchBookAPI.Utils;
using System;

namespace MatchBookAPI.Seachers
{
    public class TokenAutenticacao
    {
        public string token { get; set; }   
        public string horarioCriacao { get; set; } 
        
        public string id { get; set; }

        public bool status { get; set; }    

        public UserInfo userInfo { get; set; }
        public TokenAutenticacao(String _token, string _horarioCriacao, bool _status, string _id)
        {
            this.token = _token;
            this.horarioCriacao = _horarioCriacao; 
            this.status = _status;
            this.id = _id;
        }

    }
}
