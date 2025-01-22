using LightWebShop.Infrastructure.Data.Domain;

using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace LightWebShop.Infrastructure.Data
{
    public class ApplicationDbContext : IdentityDbContext <ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Brand> Brands { get; set; }  
        public DbSet<Category> Categories { get; set; }  
        public DbSet<Product> Products { get; set; }  
        public DbSet<Order> Orders { get; set; }  
    }
}