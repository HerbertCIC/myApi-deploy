

using Microsoft.EntityFrameworkCore;
using Shop.Models;

namespace Shop.Data
{
    public class DataContext : DbContext//representação do BD na memoria
    {
        public DataContext(DbContextOptions<DataContext> options)
            : base(options)
            {               
            }
        //representação das tabelas na memoria
        public DbSet<Product> Products {get; set;}
        public DbSet<Category> Categories { get; set; }
        public DbSet<User> Users { get; set; }
    }
}