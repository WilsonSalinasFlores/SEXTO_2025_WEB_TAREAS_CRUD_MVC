using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using TiposDatos.Models.Entidades.Base;

namespace TiposDatos.Models.Entidades
{
    [Table("Productos")]
    public class ProductosModel: BaseModel
    {
        [Required(ErrorMessage = "Campo Requerido")]

        public string Nombres { get; set; }

        [Required(ErrorMessage = "Campo Requerido")]
        [Display(Name ="Código de Barras")]
        public string Codigo_Barras { get; set; }

        [Required(ErrorMessage = "Campo Requerido")]
        public int Stock {  get; set; }

        [Required(ErrorMessage = "Campo Requerido")]
        public double Precio { get; set; }

        [Display(Name = "Descripción")]
        public string Descripcion { get; set; }

        public string Notas { get; set; }


    }
}
