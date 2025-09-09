using System.ComponentModel.DataAnnotations;

namespace WebAppMVC.Models
{
    public class ProductoModel
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "El nombre es obligatorio")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "La descripción es obligatoria")]
        public string Descripcion { get; set; }

        [Required(ErrorMessage = "El precio es obligatorio")]
        [Range(0.01, double.MaxValue, ErrorMessage = "El precio debe ser mayor a 0")]
        public decimal Precio { get; set; }

        [Required(ErrorMessage = "El stock es obligatorio")]
        [Range(0, int.MaxValue, ErrorMessage = "El stock no puede ser negativo")]
        public int Stock { get; set; }

        //Propiedad de navegación para la relación con DetallePedido
        //Un producto puede estar en muchos detalles de pedido 1-N
        public ICollection<DetallePedidoModel> DetallePedidos { get; set; }
    }
}
