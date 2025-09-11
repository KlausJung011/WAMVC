using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAppMVC.Models
{
    public class DetallePedidoModel
    {
        public int Id { get; set; }

        [Display(Name = "Fecha del Pedido")]
        [Required(ErrorMessage = "El ID del pedido es obligatorio")]
        [Range(1, int.MaxValue, ErrorMessage = "El ID de pedido debe ser mayor a 0")]
        public int IdPedido { get; set; }

        [Display(Name = "Nombre del Producto")]
        [Required(ErrorMessage = "El ID del productoes obligatorio")]
        [Range(1, int.MaxValue, ErrorMessage = "El ID de pedido debe ser mayor a 0")]
        public int IdProducto { get; set; }

        [Display(Name = "Unidades reservadas")]
        [Required(ErrorMessage = "El stock es obligatorio")]
        [Range(0, 9999999, ErrorMessage = "El stock no puede ser negativo")]
        public int Cantidad { get; set; }

        [Display(Name = "Precio por unidad")]
        [Required(ErrorMessage = "El precio es obligatorio")]
        [Column(TypeName = "decimal(10,2)")]
        [Range(0.01, 99999999.99, ErrorMessage = "El precio debe estar entre 0.01 y 99,999,999.99")]
        [RegularExpression(@"^\d{1,8}(\.\d{1,2})?$", ErrorMessage = "Máximo 8 dígitos antes y 2 después del punto decimal")]
        public decimal PrecioUnitario { get; set; }

        public PedidoModel? Pedido { get; set; }
        public ProductoModel? Producto { get; set; }
    }
}
