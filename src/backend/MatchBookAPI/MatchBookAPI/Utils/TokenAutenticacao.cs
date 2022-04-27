using System;

namespace MatchBookAPI.Seachers
{
    public class TokenAutenticacao
    {
        public string token { get; set; }   
        public string horarioCriacao { get; set; } 

        public TokenAutenticacao(String _token, string _horarioCriacao)
        {
            this.token = _token;
            this.horarioCriacao = _horarioCriacao; 
        }

    }
}
