using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Novin.Arayeshyar.Backend.Core.Entities
{
    public class Customer
    {
        public string? Fullname { get; set; }
        public string? Password { get; set; }
        public string Mobilenumber { get; set; }

        public Customer(string mobilenumber)
        {
            Mobilenumber = mobilenumber;
        }
    }
}
