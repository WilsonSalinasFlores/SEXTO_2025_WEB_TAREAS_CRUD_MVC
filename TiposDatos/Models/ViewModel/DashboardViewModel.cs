using TiposDatos.Models.Entidades;

namespace TiposDatos.Models.ViewModel
{
    public class DashboardViewModel
    {
        public int Clientes { get; set; }
        public int Productos { get; set; }

        public int Numero_Ventas { get; set; }

        public double Total_Ventas { get; set; }

        public List<VentasModel> UltimasVentas { get; set; }
    }
}
