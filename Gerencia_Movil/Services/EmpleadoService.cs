using Gerencia_Movil.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace Gerencia_Movil.Services
{
    public class EmpleadoService
    {
        public async Task<EmpleadoDto> ObtenerEmpleado()
        { 
            var client = new HttpClient();
            var url = "http://localhost:5110/api/Empleado";
            var request = new HttpRequestMessage(HttpMethod.Get, url);
            request.Headers.Add("accept", "*/*");
            var response = await client.SendAsync(request);
            var data = await response.Content.ReadAsStringAsync();
            EmpleadoDto empleado = System.Text.Json.JsonSerializer.Deserialize<EmpleadoDto>(data);

            return empleado;
        }
            
    }
}
