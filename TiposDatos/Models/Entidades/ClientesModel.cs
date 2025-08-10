using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using TiposDatos.Models.Entidades.Base;

namespace TiposDatos.Models.Entidades
{
    [Table("Clientes")]
    public class ClientesModel :BaseModel
    {
        [Required(ErrorMessage ="Campo Requerido") ]
        public string Nombres{ get; set; }

        [Required(ErrorMessage = "Campo Requerido")]
        [EmailAddress(ErrorMessage ="Campo no cumple con el formato email")]
        public string Email {  get; set; }

        [Required(ErrorMessage = "Campo Requerido")]
        [Display(Name ="Teléfono")]
        public string Telefono{ get; set; }

        [Required(ErrorMessage = "Campo Requerido")]
        [Display(Name = "Dirección")]
        public string Direccion { get; set; }

        [Required(ErrorMessage = "Campo Requerido")]
        [Display(Name = "Cédula o RUC")]
        public string Cedula_Ruc { get; set; }

    }
}
