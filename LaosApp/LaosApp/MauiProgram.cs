using CommunityToolkit.Maui;
using Microsoft.Extensions.Logging;
using Material.Components.Maui.Extensions;

namespace LaosApp
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .UseMauiCommunityToolkit()
                .UseMaterialComponents()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                    fonts.AddFont("Sanchez-Regular.ttf", "Sanchez");
                    fonts.AddFont("Syne - ExtraBold.ttf", "SyneExtra");
                    fonts.AddFont("MaterialIcons-Regular.ttf", "Icons");

                });

#if DEBUG
    		builder.Logging.AddDebug();
#endif

            return builder.Build();
        }


    }
}
