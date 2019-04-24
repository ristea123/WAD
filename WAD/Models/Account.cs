using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WAD.Models
{
    public class Account
    {
        public string User { get; set; }
        public string Password { get; set; }
        public bool LoggedIn { get; set; }
    }
}
