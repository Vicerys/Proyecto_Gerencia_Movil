using Gerencia_Movil.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace Gerencia_Movil.Services
{
    public class DisponibilidadService
    {
        public async Task<DisponibilidadDto> ObtenerDisponibilidad()
        {
            var client = new HttpClient();
            var request = new HttpRequestMessage(HttpMethod.Get, "http://localhost:5110/api/Disponibilidad");
            request.Headers.Add("accept", "*/*");
            var response = await client.SendAsync(request);
            response.EnsureSuccessStatusCode();
            
            var data = await response.Content.ReadAsStringAsync();
            DisponibilidadDto disponibilidad = System.Text.Json.JsonSerializer.Deserialize<DisponibilidadDto>(data);

            return disponibilidad;
        }
    }
}
