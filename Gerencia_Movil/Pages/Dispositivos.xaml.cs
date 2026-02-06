using Gerencia_Movil.Dtos;
using Gerencia_Movil.Services;

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

    private async void Button_SolicitarDispositivos(object sender, EventArgs e)
    {
        //Nueva instancia de Equipo-Empleado
    }

    private async void WebServices()
    {
        equipos = await _servicio.Equipo.ObtenerEquipos();

        EquiposUsadosCollectionView.ItemsSource = equipos;
        EquiposDisponiblesCollectionView.ItemsSource = equipos;
    }


}