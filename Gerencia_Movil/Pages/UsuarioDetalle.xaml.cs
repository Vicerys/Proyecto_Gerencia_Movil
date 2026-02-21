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
        empleado = await _service.Empleado.ObtenerEmpleado(Sesion.IdEmpleado);
        LabelNombreUsuario.Text = empleado.Nombre;
        LabelPuesto.Text = empleado.PuestoId.ToString();
        LabelUbicacion.Text = empleado.Ubicacion; 
        LabelUsuario.Text = empleado.Usuario;
    } 
}