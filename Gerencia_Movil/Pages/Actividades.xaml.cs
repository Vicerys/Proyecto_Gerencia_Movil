namespace Gerencia_Movil.Pages;

public partial class Actividades : ContentPage
{
	public Actividades()
	{
		InitializeComponent();
	}
    private async void Button_UsuarioDetalle(object sender, EventArgs e)
    {
        await Navigation.PushModalAsync(new UsuarioDetalle());
    }
}