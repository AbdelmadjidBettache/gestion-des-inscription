using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetFinal
{
    public class Agent
    {
        private string username="";
        private string password="";

        public Agent(string username, string password)
        {
            this.Password = password;
            this.Username = username;
        }

        public string Password { get => password; set => password = value; }
        public string Username { get => username; set => username = value; }
    }
}
