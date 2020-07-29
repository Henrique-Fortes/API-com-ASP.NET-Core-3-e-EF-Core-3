using Microsoft.EntityFrameworkCore;
using revisaoef.Models;

namespace revisaoef.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options)
            : base(options)
            {

            }
        
        public DbSet<Product> Products {get; set;}
        public DbSet<Category> Categories {get; set;}
    }
}
    

