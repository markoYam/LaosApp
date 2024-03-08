using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaosApp.Models
{
    public class LoginModel
    {
        public string Mail { get; set; }
        public string Password { get; set; }

        public string Token { get; set; }

        public int LoginType { get; set; }
        
    }
}
