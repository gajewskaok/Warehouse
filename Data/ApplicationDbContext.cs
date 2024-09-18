using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using WarehouseApp.Models;

namespace WarehouseApp.Data
{
    public class ApplicationDbContext : IdentityDbContext
    { 
        public DbSet<Category> Categories { get; set; }
        public DbSet<WarehouseApp.Models.Product> Product { get; set; }
        public DbSet<WarehouseApp.Models.Product> Suppliers { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
            Database.EnsureCreated();  //tworzenie bazy danych
        }
        public DbSet<WarehouseApp.Models.Supplier> Supplier { get; set; } = default!;
    }
}
