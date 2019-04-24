using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WAD.Models
{
    public class Developer : Account
    {
        public int DeveloperId { get; set; }
        public string DevelopedGames { get; set; }
    }
}
