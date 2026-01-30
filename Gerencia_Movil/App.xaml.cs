using Gerencia_Movil.Pages;
using Microsoft.Extensions.DependencyInjection;

namespace Gerencia_Movil
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
        }

        protected override Window CreateWindow(IActivationState? activationState)
        {
            return new Window(new Login());
        }
    }
}