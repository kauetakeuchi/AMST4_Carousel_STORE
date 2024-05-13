using AMST4_Carousel.MVC.Models;
using Microsoft.EntityFrameworkCore;

namespace AMST4_Carousel.MVC.Context
{
    public class ApplicationDataContext : DbContext
    {
        
        public ApplicationDataContext(DbContextOptions<ApplicationDataContext> options) : base(options)
        { 
        
        }
        public DbSet<Category> Category { get; set; }
        public DbSet<Product> Product { get; set; }
    }
}
