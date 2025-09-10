using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAppMVC.Models
{
    public class PedidoModel
    {
        public int Id { get; set; }

        [Display(Name = "Fecha de Vencimiento")]
        [Required(ErrorMessage = "La fecha de entrega es obligatoria")]
        [DataType(DataType.Date)]
        [CustomValidation(typeof(PedidoModel), nameof(ValidateFechaVencimiento))]
        public DateTime FechaPedido { get; set; }

        [Display(Name = "ID del Cliente")]
        [Required(ErrorMessage = "El ID del cliente es obligatorio")]
        [Range(1, int.MaxValue, ErrorMessage = "El ID de usuario debe ser mayor a 0")]
        public int IdCliente { get; set; }

        [Required(ErrorMessage = "El estado es obligatorio")]
        [Display(Name = "Estado")]
        public string Estado { get; set; } = "Pendiente";

        [Display(Name = "Precio")]
        [Required(ErrorMessage = "El precio es obligatorio")]
        [Column(TypeName = "decimal(10,2)")]
        [Range(0.01, double.MaxValue, ErrorMessage = "El precio debe ser mayor a 0")]
        public decimal MontoTotal { get; set; }

        //Un pedido pertenece a un solo cliente
        public ClienteModel? Cliente { get; set; }
        //Un pedido puede tener muchos detalles de pedido 1-N
        public ICollection<DetallePedidoModel>? DetallePedidos { get; set; }

        public static ValidationResult ValidateFechaVencimiento(DateTime fechaVencimiento, ValidationContext context)
        {
            if (fechaVencimiento.Date < DateTime.Today)
            {
                return new ValidationResult("La fecha de vencimiento no puede ser anterior a hoy");
            }
            return ValidationResult.Success;
        }
    }
}