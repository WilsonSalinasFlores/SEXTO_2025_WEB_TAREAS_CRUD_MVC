namespace TiposDatos.Models.ViewModel
{
    public class ErrorViewModel
    {
        public string RequestId { get; set; }
        public bool MostrarIdRespuesta => !string.IsNullOrEmpty(RequestId);
    }
}
