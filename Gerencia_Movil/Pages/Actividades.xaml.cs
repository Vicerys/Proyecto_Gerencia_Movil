using Gerencia.Core.Dtos;
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
        var button = sender as ImageButton;
        var actividad = button?.CommandParameter as TareaDto;

        if (actividad == null)
            return;

        Navigation.PushModalAsync(new ActividadDetalle(_Servicio, actividad));
    }

    private async void WebServices()
    {
        //Llamar al servicio para obtener las tareas y asignarlas a la CollectionViews
        tareas = await _Servicio.Tarea.ObtenerTareas();
        TareasCollectionView.ItemsSource = tareas;

        if (tareas == null || tareas.Count == 0)
        {
            await DisplayAlert("Información", "No hay tareas disponibles.", "OK");
        }
    }

    private void Button_Completar(object sender, EventArgs e)
    {
        //Cambiar status de la tarea a "completada" y actualizar en el backend
    }
}