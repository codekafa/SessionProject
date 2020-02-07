using Data.RHC.Entity;
using Microsoft.EntityFrameworkCore;

namespace Data.RHC
{
    public class RHCContext : DbContext
    {

        private const string ConnectionString = @"server=.;database=test;trusted_connection=true;";

        protected override void OnConfiguring(DbContextOptionsBuilder optionBuilder)
        {
            optionBuilder.UseSqlServer(ConnectionString);
        }

        public DbSet<user> User { get; set; }
        public DbSet<user_address> UserAdress { get; set; }

    }
}
