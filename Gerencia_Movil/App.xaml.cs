using Gerencia_Movil.Pages;
using Gerencia_Movil.Services;
using Microsoft.Extensions.DependencyInjection;

namespace Gerencia_Movil
{
    public partial class App : Application
    {
        Servicio _servicio;
        public App(Servicio servicio)
        {
            InitializeComponent();
            _servicio = servicio;

        }

        protected override Window CreateWindow(IActivationState? activationState)
        {
            return new Window(new Login(_servicio));
        }
    }
}