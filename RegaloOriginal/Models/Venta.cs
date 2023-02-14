using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ComuniDev.WebEFCore.API.Models
{
    [Table("Venta")]
    public class Venta
    {
        [Key]
        public int Id { get; set; }
        public DateTime Fecha { get; set; }
        public int MontoTotal { get; set; }

    }
}
