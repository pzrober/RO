using Microsoft.EntityFrameworkCore;

namespace ComuniDev.WebEFCore.API.Models
{
    public class RegaloOriginalDbContext: DbContext
    {
        public RegaloOriginalDbContext()
        {

        }
        public RegaloOriginalDbContext(DbContextOptions<RegaloOriginalDbContext> options): base(options)
        {

        }

    
        public virtual DbSet<Producto> Producto { get; set; }
        public virtual DbSet<ItemVenta> ItemVenta { get; set; }
        public virtual DbSet<Venta> Venta { get; set; }

    }
}
