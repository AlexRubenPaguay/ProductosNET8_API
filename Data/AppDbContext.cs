using Microsoft.EntityFrameworkCore;
using ProductosNet8_API.Models;
namespace ProductosNet8_API.Data
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options): base(options)
        {
            
        }
        public DbSet<Producto> Productos { get; set; }       
    }
}
