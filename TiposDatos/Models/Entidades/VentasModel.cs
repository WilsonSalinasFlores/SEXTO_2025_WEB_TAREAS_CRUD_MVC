using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using TiposDatos.Models.Entidades.Base;

namespace TiposDatos.Models.Entidades
{
    [Table("Ventas")]
    public class VentasModel: BaseModel
    {

        [Required(ErrorMessage = "Campo Requerido")]
        [Display(Name ="Fecha de Venta")]
        public DateTime FechaVenta { get; set; }

        [Required(ErrorMessage = "Campo Requerido")]
        [Display(Name ="Código de Venta")]
        public string Codigo_Venta { get; set; }

        [Required(ErrorMessage = "Campo Requerido")]
        public string Nota {  get; set; }

        public double Sub_Total { get; set; }

        public string Estado_Venta { get; set; }

        public double? Descuento { get; set; }

        [Display(Name ="Total Venta")]
        public double Total_Venta { get; set; }

        public string Metodo_Pago { get; set; }


        [Display(Name ="ClienteId")]
        [ForeignKey("ClientesModel")]
        public int ClientesModelId { get;set; }
        public ClientesModel ClientesModel { get; set; }

        public ICollection<ProductosVendidosModel> Productos_Modelos { get; set; }

        public VentasModel()
        {
            Productos_Modelos = new List<ProductosVendidosModel>();
        }
    }
}
