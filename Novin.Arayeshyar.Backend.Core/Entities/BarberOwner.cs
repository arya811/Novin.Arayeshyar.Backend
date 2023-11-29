using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Novin.Arayeshyar.Backend.Core.Entities
{
    public class BarberOwner
    {
        public string Fullname { get; set; }
        public string Password { get; set; }
        public string Mobilenumber { get; set; }
        public string? BarberShopname { get; set; }

        public BarberOwner(string mobilenumber, string fullname, string password)
        {
            Mobilenumber = mobilenumber;
            Fullname = fullname;
            Password = password;
        }
    }
}
