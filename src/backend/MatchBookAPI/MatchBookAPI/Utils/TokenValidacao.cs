using System;

namespace MatchBookAPI.Seachers
{
    public class TokenValidacao
    {
        public string token { get; set; }   
        public bool validacao { get; set; }
        public string validacaoDescricao { get; set; }

        public string horarioValidacao { get; set; }

        public TokenValidacao(String _token, bool _validacao, string _horarioValidacao, string _validacaoDescricao )
        {
            this.token = _token;
            this.validacao = _validacao;
            this.horarioValidacao = _horarioValidacao; 
            this.validacaoDescricao = _validacaoDescricao;
        }

    }
}
