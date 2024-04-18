using Pr26_Yar.Models;
using Microsoft.EntityFrameworkCore;
using Pr26_Yar.Classes.Common;

namespace Pr26_Yar.Classes
{
    public class ClubsContext : DbContext
    {
        public DbSet<Clubs> Clubs { get; set; }
        public ClubsContext()=> Database.EnsureCreated();

            protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) => optionsBuilder.UseMySql(Config.ConnectionConfig, Config.Version);
    }
}
