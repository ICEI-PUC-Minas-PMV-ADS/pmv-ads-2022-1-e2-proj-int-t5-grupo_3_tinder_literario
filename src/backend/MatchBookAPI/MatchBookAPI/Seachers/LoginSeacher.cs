using Microsoft.AspNetCore.Mvc;
using System;

namespace MatchBookAPI.Seachers
{
    public class EmailSeacher
    {
        public string email { get; set; }

        public EmailSeacher()
        {

        }

        public EmailSeacher(string email)
        {
            this.email = email;
        }
    }
}
