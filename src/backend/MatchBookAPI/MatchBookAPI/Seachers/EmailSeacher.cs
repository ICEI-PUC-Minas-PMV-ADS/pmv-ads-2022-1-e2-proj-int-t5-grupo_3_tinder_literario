using Microsoft.AspNetCore.Mvc;
using System;

namespace MatchBookAPI.Seachers
{
    public class LoginSeacher
    {
        public string email { get; set; }
        public string senha { get; set; }

        public string celular { get; set; }
        public string nome { get; set; }
        public string id { get; set; }

        public LoginSeacher()
        {

        }

        public LoginSeacher(string nome, string senha, string id)
        {
            this.email = nome;
            this.senha = senha;
            this.id = id;  
        }
    }
}
