using Microsoft.EntityFrameworkCore;
using RotinaBackup.Data.Models; 

namespace RotinaBackup.Data
{
    public class Context : DbContext
    {
        private readonly string _connection = @"Data Source=(LocalDB)\MSSQLLocalDB;Integrated Security=True";
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseLazyLoadingProxies().UseSqlServer(_connection);
        }
        public DbSet<BackupSettings> BackupSettings { get; set; }
        public DbSet<Server> Server { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

        }


    }
}
