namespace MatchBookAPI.Utils
{
    public class CadastroStatus
    {
        public bool status { get; set; }
        public string horarioCriacao { get; set; }

        public string mensagem { get; set; }

        public CadastroStatus(string mensagem, string _horarioCriacao, bool _status)
        {
            this.mensagem = mensagem;
            this.horarioCriacao = _horarioCriacao;
            this.status = _status;
        }
    }
}
