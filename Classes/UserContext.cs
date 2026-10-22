using Kino_Alikin.Classes.Common;
using Kino_Alikin.Models;
using Microsoft.EntityFrameworkCore;

namespace Kino_Alikin.Classes
{
    public class UserContext : DbContext
    {
        public DbSet<Users> Users { get; set; }

        public UserContext() =>
            Database.EnsureCreated();

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) =>
            optionsBuilder.UseMySql(Config.ConnectionConfig, Config.Version);
    }
}
