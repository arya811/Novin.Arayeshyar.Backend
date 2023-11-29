using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Novin.Arayeshyar.Backend.Core.Entities
{
    public class SistemAdmin
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string? Fullname { get; set; }
        public string Mobilenumber { get; set; }

        public SistemAdmin(string username, string password, string mobilenumber)
        {
            Username = username;
            Password = password;
            Mobilenumber = mobilenumber;
        }
    }
}
