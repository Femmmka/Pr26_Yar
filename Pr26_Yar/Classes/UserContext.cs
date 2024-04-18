using Pr26_Yar.Models;
using Microsoft.EntityFrameworkCore;
using Pr26_Yar.Classes.Common;

namespace Pr26_Yar.Classes
{
    public class UserContext : DbContext
    {
        public DbSet<Users> Users { get; set; }
        public UserContext() => Database.EnsureCreated();
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) =>
            optionsBuilder.UseMySql(Config.ConnectionConfig, Config.Version);
    }
}
