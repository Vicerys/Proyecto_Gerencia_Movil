using Gerencia_Movil.Pages;
using Gerencia_Movil.Services;

namespace Gerencia_Movil
{
    public partial class MainPage : ContentPage
    {
        Servicio _Servicio;
        public MainPage(Servicio servicio)
        {
            InitializeComponent();
            _Servicio = servicio;
            //EquipoService service = new EquipoService();
            //CollectionView.ItemsSource = service.ObtenerTodos();
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

        private void Button_Close(object sender, EventArgs e)
        {
            // Limpiar sesión en memoria
            Sesion.Token = null;
            Sesion.IdEmpleado = 0;

            // Volver al login y resetear navegación
            Application.Current.MainPage = new Login(_Servicio);
        }
    }
}

