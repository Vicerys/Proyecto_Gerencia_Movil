using Gerencia_Movil.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace Gerencia_Movil.Services
{
    public class EquipoService
    {

        public async Task<List<EquipoDto>> ObtenerEquipos()
        {
            var client = new HttpClient();
            var request = new HttpRequestMessage(
                HttpMethod.Get,
                "http://localhost:5110/api/Equipo"
            );

            request.Headers.Add("accept", "*/*");

            var response = await client.SendAsync(request);
            response.EnsureSuccessStatusCode();

            var data = await response.Content.ReadAsStringAsync();

            var equipos = System.Text.Json.JsonSerializer.Deserialize<List<EquipoDto>>(data);

            return equipos;
        }

    }
}
