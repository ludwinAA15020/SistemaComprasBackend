using System.ComponentModel.DataAnnotations;

namespace SistemaComprasBackend.Models
{
    public class Producto
    {
        [Key]
        public string? id_producto { get; set; }
        [Required]     
        public string? nombre_producto { get; set; }
        [Required]
        public string? caracteristica { get; set; }
        [Required]
        public string? medida { get; set; }

       
    }
}
