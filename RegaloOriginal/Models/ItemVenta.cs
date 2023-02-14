using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ComuniDev.WebEFCore.API.Models
{
    [Table("ItemVenta")]
    public class ItemVenta
    {
        [Key]
        [Column(TypeName ="int")]
        public int Id { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal Precio { get; set; }

        public virtual ICollection<Venta>? VentaId { get; set; }
        public virtual ICollection<Producto>? ProductoId { get; set; }

    }
}
