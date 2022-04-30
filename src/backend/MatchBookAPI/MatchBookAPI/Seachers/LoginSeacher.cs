using Microsoft.AspNetCore.Mvc;
using System;

namespace MatchBookAPI.Seachers
{
    public class LoginSeacher
    {
        public string email { get; set; }
        public string senha { get; set; }

        public LoginSeacher()
        {

        }

        public LoginSeacher(string nome, string senha)
        {
            this.email = nome;
            this.senha = senha;
        }
    }
}
