using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using TiposDatos.Models.Entidades.Base;

namespace TiposDatos.Models.Entidades
{
    [Table("ConfiguracionesEmpresa")]
    public class ConfiguracionesModel:BaseModel
    {
        [Required(ErrorMessage ="El campo es requerido")]
        public string Logo { get; set; }
        [Required(ErrorMessage = "El campo es requerido")]
        public string Nombre_Empresa { get; set; }
        [Required(ErrorMessage = "El campo es requerido")]
        [EmailAddress(ErrorMessage ="El campo debe ser un correo valido")]
        public string Email { get; set; }
        public string? Web { get; set; }
        [Required(ErrorMessage = "El campo es requerido")]
        public string Direccion { get; set; }
        [Required(ErrorMessage = "El campo es requerido")]
        [Phone(ErrorMessage ="El campo debe ser un telefono valido")]
        public string Telefono { get; set; }

        [Required(ErrorMessage = "El campo es requerido")]
        public string RUC { get; set; } 
    }
}
