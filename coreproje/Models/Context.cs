using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace coreproje.Models
{
    public class Context : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) // connection string
        {
            optionsBuilder.UseSqlServer("server=(LocalDB)\\MSSQLLocalDB; database=corePersonel; integrated security = true;");
        }

        public DbSet<Departman> Departmans { get; set; } 
        public DbSet<Personel> Personels { get; set; } 
        public DbSet<Login> Logins { get; set; } 
    }
}
