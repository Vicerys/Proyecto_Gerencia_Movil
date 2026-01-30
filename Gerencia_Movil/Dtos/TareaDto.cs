using System.Text.Json.Serialization;

namespace Gerencia_Movil.Dtos
{
    public class TareaDto
    {
        
        [JsonPropertyName("tareaId")]
        public int TareaId { get; set; }

        [JsonPropertyName("nombre")]
        public string Nombre { get; set; }
        
        [JsonPropertyName("tipo")]
        public string Tipo { get; set; }

        [JsonPropertyName("procesoId")]
        public int ProcesoId { get; set; }
        
        [JsonPropertyName("estadoId")]
        public int EstadoId { get; set; }
    }
}
