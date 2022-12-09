using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MyShop.Core.Models;

namespace MyShop.WebUI.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<MyShop.Core.Models.Product> Product { get; set; }
        //public DbSet<MyShop.Core.Models.Product> Product { get; set; }
        //public DbSet<MyShop.Core.Models.ProductCategory> ProductCategory { get; set; }
    }
}