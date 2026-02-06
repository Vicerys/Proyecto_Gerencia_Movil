using Gerencia_Movil.Services;

namespace Gerencia_Movil.Pages;

public partial class Inicio : ContentPage
{
    Servicio _Servicio;
    public Inicio(Servicio servicio)
	{
		InitializeComponent();
        _Servicio = servicio;
	}

    private async void Button_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Actividades(_Servicio));
    }
    private async void Button_Clicked_1(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Dispositivos(_Servicio));
    }

    private async void Button_UsuarioDetalle(object sender, EventArgs e)
    {
        await Navigation.PushModalAsync(new UsuarioDetalle(_Servicio));
    }
}
    