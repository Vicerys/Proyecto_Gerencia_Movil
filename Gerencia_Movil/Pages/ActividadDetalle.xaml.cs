using Gerencia_Movil.Services;

namespace Gerencia_Movil.Pages;

public partial class ActividadDetalle : ContentPage
{
    Servicio _service;
    public ActividadDetalle(Servicio service)
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
        /*TareaDto tarea;
        tarea = await _service.Tarea.ObtenerTarea(); //Falta pasar el id de la tarea
        LabelNombreActividad.Text = tarea.Nombre;
        LabelDescripcion.Text = tarea.Descripcion;
        LabelFechaInicio.Text = tarea.FechaInicio.ToString();
        LabelFechaFin.Text = tarea.FechaFin.ToString();
        LabelEstado.Text = tarea.EstadoId.ToString();*/
    }
}