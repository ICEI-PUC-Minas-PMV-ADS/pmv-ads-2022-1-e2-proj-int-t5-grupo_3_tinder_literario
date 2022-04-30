using System;

namespace MatchBookAPI.Seachers
{
    public class TokenAutenticacao
    {
        public string token { get; set; }   
        public string horarioCriacao { get; set; } 
        
        public bool status { get; set; }    
        public TokenAutenticacao(String _token, string _horarioCriacao, bool _status)
        {
            this.token = _token;
            this.horarioCriacao = _horarioCriacao; 
            this.status = _status;
        }

    }
}
