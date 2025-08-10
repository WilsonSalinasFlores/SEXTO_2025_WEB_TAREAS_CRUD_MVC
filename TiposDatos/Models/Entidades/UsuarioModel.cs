using System.ComponentModel.DataAnnotations;
using TiposDatos.Models.Entidades.Base;

namespace TiposDatos.Models.Entidades
{
    public class UsuarioModel : BaseModel
    {
        [EmailAddress(ErrorMessage ="El formato no es de correo electrónico")]
        [Required(ErrorMessage ="El campo es requerido")]
        public string Email { get; set; }

        [Required(ErrorMessage = "El campo es requerido")]
        public string Password { get; set; }

        [Required(ErrorMessage = "El campo es requerido")]
        public string ConfirmPassword { get; set; }
    }
}
