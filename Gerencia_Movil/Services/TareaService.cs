using Gerencia.Core.Dtos;
namespace Gerencia_Movil.Services
{
    public class TareaService
    {
        public async Task<List<TareaDto>> ObtenerTareas()
        {
            var client = new HttpClient();
            var url = "http://localhost:5110/api/Tarea";
            var request = new HttpRequestMessage(HttpMethod.Get, url);
            request.Headers.Add("accept", "");
            var response = await client.SendAsync(request);
            response.EnsureSuccessStatusCode();

            var data = await response.Content.ReadAsStringAsync();
            var tareas = System.Text.Json.JsonSerializer.Deserialize<List<TareaDto>>(data);

            return tareas;
        }

        public async Task<TareaDto> ObtenerTarea(int idTarea)
        {
            var client = new HttpClient();
            var url = $"http://localhost:5110/api/Tarea/{idTarea}";
            var request = new HttpRequestMessage(HttpMethod.Get, url);
            request.Headers.Add("accept", "*/*");
            var response = await client.SendAsync(request);
            response.EnsureSuccessStatusCode();
            var data = await response.Content.ReadAsStringAsync();
            TareaDto tarea = System.Text.Json.JsonSerializer.Deserialize<TareaDto>(data);
            return tarea;
        }
    }
}
