using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WAD.Models
{
    public class Client : Account
    {
        public int ClientId { get; set; }
        public string Favourites { get; set; }
    }
}
