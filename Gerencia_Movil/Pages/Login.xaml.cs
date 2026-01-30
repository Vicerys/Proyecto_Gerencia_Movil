using Gerencia_Movil.Dtos;
using Gerencia_Movil.Services;

namespace Gerencia_Movil.Pages;

public partial class Login : ContentPage
{
    Servicio _servicio;
	public Login(Servicio servicio)
	{
		InitializeComponent();
        _servicio = servicio;
    }
    private async void ButtonIniciarSesion_Clicked(object sender, EventArgs e)
    {
        string usuario = EntryUsuario.Text;
        string contrasena = EntryContrasena.Text;

        TokenDto login;
        login = await _servicio.InicioSesion.InicioSesion(usuario, contrasena);
        
        
        if (login != null)
        {
            Application.Current.MainPage = new AppShell();
        }else
        {
            DisplayAlert("Error", "Usuario o contraseña incorrectos", "OK");
        }
    }
}