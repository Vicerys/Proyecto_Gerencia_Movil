using Gerencia_Movil.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace Gerencia_Movil.Services
{
    public class PuestoService
    {
        public async Task<PuestoDto> ObtenerPuesto()
        {
            var client = new HttpClient();
            var request = new HttpRequestMessage(HttpMethod.Get, "http://localhost:5110/api/TipoPuesto");
            request.Headers.Add("accept", "*/*");
            var response = await client.SendAsync(request);
            response.EnsureSuccessStatusCode();

            var data = await response.Content.ReadAsStringAsync();
            PuestoDto puesto = System.Text.Json.JsonSerializer.Deserialize<PuestoDto>(data);

            return puesto;
        }
    }
}
