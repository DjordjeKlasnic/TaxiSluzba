using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TaxiSluzba_backend.Models.DTO
{
    public class LoginDTO
    {
        private string username;
        private string password;

        public LoginDTO(string username, string password)
        {
            this.Username = username;
            this.Password = password;
        }

        public LoginDTO()
        {

        }

        public string Username { get { return username; } set { username = value; } }
        public string Password { get { return password; } set { password = value; } }
    } 
}