namespace Gerencia_Movil.Pages;

public partial class Login : ContentPage
{
	public Login()
	{
		InitializeComponent();
	}
    private void ButtonIniciarSesion_Clicked(object sender, EventArgs e)
    {
        string usuario = EntryUsuario.Text;
        string contrasena = EntryContrasena.Text;

        if (usuario == "admin" && contrasena == "password")
        {
            Application.Current.MainPage = new Inicio();
        }else
        {
            DisplayAlert("Error", "Usuario o contraseña incorrectos", "OK");
        }
    }
}