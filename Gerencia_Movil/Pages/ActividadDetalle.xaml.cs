using Gerencia.Core.Dtos;
using Gerencia_Movil.Services;

namespace Gerencia_Movil.Pages;

public partial class ActividadDetalle : ContentPage
{
    Servicio _service;
    TareaDto _tarea;
    public ActividadDetalle(Servicio service, TareaDto tarea)
	{
		InitializeComponent();
        _service = service;
        _tarea = tarea;
        WebServices();
    }

    private void Button_Clicked(object sender, EventArgs e)
    {
         Navigation.PopModalAsync();
    }

    private async void WebServices()
    {
        //TareaDto tarea;
        //tarea = await _service.Tarea.ObtenerTarea(); //Falta pasar el id de la tarea
        //LabelNombreActividad.Text = _tarea.Nombre;
        LabelDescripcion.Text = _tarea.Descripcion;
        //LabelUbicacion.Text = _tarea.Ubicacion;
        //LabelFechaLimite.Text = _tarea.FechaLimite.ToString("dd/MM/yyyy");
        //LabelEstado.Text = _tarea.EstadoId.ToString();
    }
}