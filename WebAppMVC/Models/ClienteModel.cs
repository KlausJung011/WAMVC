using System.ComponentModel.DataAnnotations;

namespace WebAppMVC.Models
{
    public class ClienteModel
    {
        public int Id { get; set; }

        [Display(Name = "Nombre del cliente")]
        [Required(ErrorMessage = "El nombre es obligatorio")]
        [StringLength(100, MinimumLength = 3, ErrorMessage = "El nombre debe tener entre 3 y 100 caracteres")]
        public string Nombre { get; set; }

        [Display(Name = "Correo electrónico")]
        [Required(ErrorMessage = "El correo es obligatorio")]
        [EmailAddress(ErrorMessage = "Formato de correo electrónico inválido.")]
        [StringLength(100, MinimumLength = 3, ErrorMessage = "El nombre debe tener entre 3 y 100 caracteres")]
        public string Email { get; set; }

        [Display(Name = "Dirección del cliente")]
        [Required(ErrorMessage = "La dirección es obligatorio")]
        [StringLength(200, MinimumLength = 3, ErrorMessage = "El nombre debe tener entre 3 y 100 caracteres")]
        public string? Direccion { get; set; }

        //Un cliente puede tener varios pedidos
        public ICollection<PedidoModel>? Pedidos { get; set; }
    }
}