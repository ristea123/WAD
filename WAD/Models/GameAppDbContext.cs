using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WAD.Models
{
    public class GameAppDbContext : DbContext
    {
        public GameAppDbContext(DbContextOptions<GameAppDbContext> options) : base(options)
        { }

        public DbSet<Client> Clients { get; set; }
        public DbSet<Developer> Developers { get; set; }
        public DbSet<Reviewer> Reviewers { get; set; }
        public DbSet<Game> Games { get; set; }
    }
}
