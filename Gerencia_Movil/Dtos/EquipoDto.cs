using System.Text.Json.Serialization;

namespace Gerencia_Movil.Dtos
{
    public class EquipoDto
    {
        
        [JsonPropertyName("equipoId")]
        public int EquipoId { get; set; }

        
        [JsonPropertyName("nombre")]
        public string Nombre { get; set; }

       
        [JsonPropertyName("ubicacion")]
        public string Ubicacion { get; set; }

      
        [JsonPropertyName("foto")]
        public string Foto { get; set; }

        [JsonPropertyName("especificaciones")]
        public string EspecificacionesTecnicas { get; set; }

        [JsonPropertyName("mantenimiento")]
        public int FrecuenciaMantenimiento { get; set; }

        [JsonPropertyName("disponibilidadId")]
        public int DisponibilidadId { get; set; }
    }
}
