using Gerencia_Movil.Services;
using Microsoft.Extensions.Logging;

namespace Gerencia_Movil
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                });

#if DEBUG
    		builder.Logging.AddDebug();
#endif
            builder.Services.AddSingleton<EmpleadoService>();
            builder.Services.AddSingleton<DisponibilidadService>();
            builder.Services.AddSingleton<EquipoService>();
                builder.Services.AddSingleton<EstadoService>();
                builder.Services.AddSingleton<PuestoService>();
                builder.Services.AddSingleton<TareaEquipoService>();
                builder.Services.AddSingleton<TareaService>();
                builder.Services.AddSingleton<InicioSesionService>();

                builder.Services.AddSingleton<Servicio>();

            builder.Services.AddSingleton<MainPage>();
            builder.Services.AddSingleton<Pages.Inicio>();
            builder.Services.AddSingleton<Pages.Actividades>();
            builder.Services.AddSingleton<Pages.Dispositivos>();
                builder.Services.AddSingleton<Pages.UsuarioDetalle>();
                builder.Services.AddSingleton<Pages.ActividadDetalle>();
            builder.Services.AddSingleton<Pages.Login>();
            return builder.Build();
        }
    }
}
