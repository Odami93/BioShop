using Microsoft.EntityFrameworkCore;
using BioShopDB.Models;
using BioShop.Models;

namespace BioShopDB.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Producto> Productos { get; set; }
        public DbSet<Tienda> Tiendas { get; set; }
        public DbSet<Informacion> Informaciones { get; set; }
    }
}
