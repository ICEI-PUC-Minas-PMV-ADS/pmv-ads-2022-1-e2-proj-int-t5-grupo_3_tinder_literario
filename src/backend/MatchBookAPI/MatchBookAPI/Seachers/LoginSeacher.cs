using Microsoft.AspNetCore.Mvc;
using System;

namespace MatchBookAPI.Seachers
{
    public class LoginSeacher
    {
        public string nome { get; set; }
        public string senha { get; set; }

        public LoginSeacher()
        {

        }

        public LoginSeacher(string nome, string senha)
        {
            this.nome = nome;
            this.senha = senha;
        }
    }
}
