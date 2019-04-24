using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WAD.Models
{
    public class Reviewer : Account
    {
        public int ReviewerId { get; set; }
        public string ReviewedGames { get; set; }
    }
}
