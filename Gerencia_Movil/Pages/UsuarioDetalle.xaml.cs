using Gerencia_Movil.Dtos;
using Gerencia_Movil.Services;

namespace Gerencia_Movil.Pages;

public partial class UsuarioDetalle : ContentPage
{
    Servicio _service;
    public UsuarioDetalle(Servicio service)
	{
		InitializeComponent();
        _service = service;
        WebServices();

	}
    private void Button_Clicked(object sender, EventArgs e)
    {
        Navigation.PopModalAsync();
    }

    private async void WebServices()
    {
        EmpleadoDto empleado;
        empleado = await _service.Empleado.ObtenerEmpleado(); //Falta pasar el id del empleado
        LabelNombreUsuario.Text = empleado.Nombre;
        LabelPuesto.Text = empleado.PuestoId.ToString();
        LabelUbicacion.Text = empleado.Ubicacion;
        LabelUsuario.Text = empleado.Usuario;
        //string data= await ObtenerEmpleado();
        //LabelNombreUsuario.Text = data;
    }

    /*private async Task<string> ObtenerEmpleado()
    {
        var client = new HttpClient();
        var url = "http://localhost:5110/api/Empleado";
        var request = new HttpRequestMessage(HttpMethod.Get, url);*/
        //request.Headers.Add("accept", "*/*");
        /*
        var response = await client.SendAsync(request);
        response.EnsureSuccessStatusCode();
        var data = await response.Content.ReadAsStringAsync();
        Console.WriteLine(await response.Content.ReadAsStringAsync());

        return data;
    }*/
}