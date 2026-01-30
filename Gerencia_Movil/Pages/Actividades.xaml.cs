using Gerencia_Movil.Dtos;
using Gerencia_Movil.Services;

namespace Gerencia_Movil.Pages;

public partial class Actividades : ContentPage
{
    Servicio _Servicio;
    private List<TareaDto> tareas;
    public Actividades(Servicio servicio)
	{
		InitializeComponent();
        _Servicio = servicio;
        WebServices();
    }
    private async void Button_UsuarioDetalle(object sender, EventArgs e)
    {
        await Navigation.PushModalAsync(new UsuarioDetalle(_Servicio));
    }

    private void Button_DetallesdeActividad(object sender, EventArgs e)
    {
        Navigation.PushModalAsync(new ActividadDetalle(_Servicio));
    }
    private async void WebServices()
    {
        tareas = await _Servicio.Tarea.ObtenerTareas();

        TareasCollectionView.ItemsSource = tareas;
    }
}