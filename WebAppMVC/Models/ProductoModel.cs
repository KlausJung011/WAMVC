using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAppMVC.Models
{
    public class ProductoModel
    {
        public int Id { get; set; }

        [Display(Name = "Nombre del producto")]
        [Required(ErrorMessage = "El nombre es obligatorio")]
        [StringLength(100, MinimumLength = 3, ErrorMessage = "El nombre debe tener entre 3 y 100 caracteres")]
        public string Nombre { get; set; }

        [Display(Name = "Descripción")]
        [Required(ErrorMessage = "La descripción es obligatoria")]
        [StringLength(500)]
        public string Descripcion { get; set; }

        [Display(Name = "Precio")]
        [Required(ErrorMessage = "El precio es obligatorio")]
        [Column(TypeName = "decimal(10,2)")]
        [Range(0.01, double.MaxValue, ErrorMessage = "El precio debe ser mayor a 0")]
        public decimal Precio { get; set; }

        [Display(Name = "Cantidad en stock")]
        [Required(ErrorMessage = "El stock es obligatorio")]
        [Range(0, 9999999, ErrorMessage = "El stock no puede ser negativo")]
        public int Stock { get; set; }

        //Propiedad de navegación para la relación con DetallePedido
        //Un producto puede estar en muchos detalles de pedido 1-N
        public ICollection<DetallePedidoModel>? DetallePedidos { get; set; }
    }
}
