namespace Gerencia_Movil.Pages;

public partial class UsuarioDetalle : ContentPage
{
	public UsuarioDetalle()
	{
		InitializeComponent();
	}
    private void Button_Clicked(object sender, EventArgs e)
    {
        Navigation.PopModalAsync();
    }
}