using Gerencia_Movil.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace Gerencia_Movil.Services
{
    public class EstadoService
    {
        public async Task<EstadoDto> ObtenerEstado() 
        { 
            var client = new HttpClient();
            var request = new HttpRequestMessage(HttpMethod.Get, "http://localhost:5110/api/Estado");
            request.Headers.Add("accept", "");
            var response = await client.SendAsync(request);
            response.EnsureSuccessStatusCode();

            var data = await response.Content.ReadAsStringAsync();
            EstadoDto estado = System.Text.Json.JsonSerializer.Deserialize<EstadoDto>(data);

            return estado;
        }
        

    }
}
