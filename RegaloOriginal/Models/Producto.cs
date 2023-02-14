using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ComuniDev.WebEFCore.API.Models
{
    [Table("Producto")]
    public class Producto
    {
        [Key]
        public int Id { get; set; }
        [Column(TypeName = "nvarchar(50)")]
        public string Nombre { get; set; }    

    }
}
