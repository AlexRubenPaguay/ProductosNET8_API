using Microsoft.EntityFrameworkCore;
using NetCoreAPI_UNO.Models;
namespace NetCoreAPI_UNO.Data
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options): base(options)
        {
            
        }
        public DbSet<Producto> Productos { get; set; }       
    }
}
