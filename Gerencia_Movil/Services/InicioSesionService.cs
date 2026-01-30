using Gerencia_Movil.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace Gerencia_Movil.Services
{
    public class InicioSesionService
    {
        public async Task<TokenDto> InicioSesion(string usuario, string contrasena)
        {
            var client = new HttpClient();
            var request = new HttpRequestMessage(HttpMethod.Post, "http://localhost:5110/api/Empleado/IniciodeSesiones");
            request.Headers.Add("accept", "*/*");
            var content = new StringContent(
    $"{{ \"usuario\": \"{usuario}\", \"contrasena\": \"{contrasena}\" }}",
    System.Text.Encoding.UTF8,
    "application/json"
);

            request.Content = content;
            var response = await client.SendAsync(request);
            response.EnsureSuccessStatusCode();

            var data = await response.Content.ReadAsStringAsync();
            TokenDto token = System.Text.Json.JsonSerializer.Deserialize<TokenDto>(data);

            return token;
        }
    }
}
