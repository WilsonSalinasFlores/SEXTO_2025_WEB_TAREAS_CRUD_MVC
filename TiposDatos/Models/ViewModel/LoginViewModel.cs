using System.ComponentModel.DataAnnotations;

namespace TiposDatos.Models.ViewModel
{
    public class LoginViewModel
    {
        [Required(ErrorMessage ="El campo es requerido")]
        [EmailAddress(ErrorMessage ="El campo no tiene el formato correcto")]
        public string Email { get; set; }
        
        [Required(ErrorMessage ="El campo es requerido")]
        public string Password { get; set; }
    }
}
