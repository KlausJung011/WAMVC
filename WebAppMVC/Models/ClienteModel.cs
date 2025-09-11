using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;

namespace WebAppMVC.Models
{
    public class ClienteModel
    {
        public int Id { get; set; }

        [Display(Name = "Nombre del cliente")]
        [Required(ErrorMessage = "El nombre es obligatorio")]
        [StringLength(100, MinimumLength = 3, ErrorMessage = "El nombre debe tener entre 3 y 100 caracteres")]
        //[Remote(action: "CheckNombreUnico", controller: "Clientes", AdditionalFields = nameof(Id), ErrorMessage = "Ya existe un cliente con ese nombre.")]
        public string Nombre { get; set; }

        [Display(Name = "Correo electrónico")]
        [Required(ErrorMessage = "El correo es obligatorio")]
        [StringLength(100, MinimumLength = 7, ErrorMessage = "El email debe tener entre 7 y 100 caracteres")]
        [EmailAddress(ErrorMessage = "Formato de correo electrónico inválido.")]
        [RegularExpression(@"^[\w\.-]+@[\w\.-]+\.\w{2,4}$", ErrorMessage = "El correo no cumple el formato requerido.")]
        public string Email { get; set; }

        [Display(Name = "Dirección del cliente")]
        [Required(ErrorMessage = "La dirección es obligatorio")]
        [StringLength(200, MinimumLength = 4, ErrorMessage = "El nombre debe tener entre 3 y 100 caracteres")]
        public string? Direccion { get; set; }

        //Un cliente puede tener varios pedidos
        public ICollection<PedidoModel>? Pedidos { get; set; }
    }
}