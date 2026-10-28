using Microsoft.EntityFrameworkCore;
using EFCorePractice.Models;

namespace EFCorePractice.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext()
        {
        }
        public DbSet<Department> Departments { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(
                    @"Server=.\SQLEXPRESS;Database=EFCoreDB;Trusted_Connection=True;TrustServerCertificate=True;");
            }
        }
    }
}