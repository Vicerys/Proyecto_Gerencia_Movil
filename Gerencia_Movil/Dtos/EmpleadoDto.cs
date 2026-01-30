using System.Text.Json.Serialization;

namespace Gerencia_Movil.Dtos
{
    public class EmpleadoDto
    {
        [JsonPropertyName("empleadoId")]
        public int EmpleadoId { get; set; }

        [JsonPropertyName("nombre")]
        public string Nombre { get; set; }
        
        [JsonPropertyName("puestoId")]
        public int PuestoId { get; set; }

        [JsonPropertyName("fechaNacimiento")]
        public DateTime FechaNacimiento { get; set; }
        
        [JsonPropertyName("edad")]
        public int Edad { get; set; }

        [JsonPropertyName("ubicacion")]
        public string Ubicacion { get; set; }

        [JsonPropertyName("foto")]
        public string Foto { get; set; }

        [JsonPropertyName("usuario")]
        public string Usuario { get; set; }
    }
}
