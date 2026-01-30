using Gerencia_Movil.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace Gerencia_Movil.Services
{
    public class TareaService
    {
        public async Task<List<TareaDto>> ObtenerTareas()
        {
            var client = new HttpClient();
            var request = new HttpRequestMessage(HttpMethod.Get, "http://localhost:5110/api/Tarea");
            request.Headers.Add("accept", "");
            var response = await client.SendAsync(request);
            response.EnsureSuccessStatusCode();

            var data = await response.Content.ReadAsStringAsync();
            var tareas = System.Text.Json.JsonSerializer.Deserialize <List<TareaDto>>(data);

            return tareas;
        }

    }
}
