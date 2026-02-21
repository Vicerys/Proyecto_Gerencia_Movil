using Gerencia.Core.Dtos;
using Gerencia_Movil.Services;
using System.Diagnostics;

namespace Gerencia_Movil.Pages;

public partial class Dispositivos : ContentPage
{
    Servicio _servicio;
    private List<EquipoDto> equipos;
    public Dispositivos(Servicio servicio)
	{
		InitializeComponent();
        _servicio = servicio;
        WebServices();
    }

    private async void Button_UsuarioDetalle(object sender, EventArgs e)
    {
        await Navigation.PushModalAsync(new UsuarioDetalle(_servicio));
	}

    private async void WebServices()
    {
        equipos = await _servicio.Equipo.ObtenerEquipos();
        EquiposUso.ItemsSource = equipos;
        EquiposDisponibles.ItemsSource = equipos;
    }

    private async void Button_Liberar_Clicked(object sender, EventArgs e)
    {
        //Cambiar status del equipo a "disponible" y actualizar en el backend
        var button = sender as Button;
        var equipo = button?.CommandParameter as EquipoDto;

        if (equipo == null)
            return;

        await DisplayAlert("Equipo liberado", equipo.Nombre, "OK");

        // Aquí haces lo que necesites con ese equipo
    }

    private async void Button_Apartar_Clicked(object sender, EventArgs e)
    {
        //Cambiar status del equipo a "apartado" y actualizar en el backend
        await DisplayAlert("Apartado", "Equipo(s) apartado(s) correctamente", "OK");
    }
}