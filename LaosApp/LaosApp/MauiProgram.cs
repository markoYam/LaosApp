using CommunityToolkit.Maui;
using Microsoft.Extensions.Logging;
using Material.Components.Maui.Extensions;
using Microsoft.Extensions.Configuration;
using System.Reflection;
using LaosApp.Models;
using LaosApp.Interfaces;
using MauiAppTest.Services;
using Microsoft.Extensions.Options;
using LaosApp.Services;
using LaosApp.Presenters;
using LaosApp.Views;
using LaosApp.Views.RegisterView;
using LaosApp.Views.ProductosView;
using LaosApp.Views.OrderView;
using LaosApp.Controls;
using 
namespace LaosApp
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {

            var aspnetcoreEnvironment = Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT");
            var a = Assembly.GetExecutingAssembly();
            using var stream = a.GetManifestResourceStream("LaosApp.appsettings.json");
            var config = new ConfigurationBuilder().AddJsonStream(stream!).Build();

            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .UseMauiCommunityToolkit()
                .UseMaterialComponents()
                .AddServices()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                    fonts.AddFont("Sanchez-Regular.ttf", "Sanchez");
                    fonts.AddFont("Syne - ExtraBold.ttf", "SyneExtra");
                    fonts.AddFont("MaterialIcons-Regular.ttf", "Icons");

                });
            builder.Configuration.AddConfiguration(config);
            builder.Services.AddSingleton<IServiceProvider, ServiceProvider>();

            Microsoft.Maui.Handlers.ElementHandler.ElementMapper.AppendToMapping("clasic", (handler, view) =>
            {
                if (view is CustomMaterialOutilineEntry)
                {
                    EntryMapper.Map(handler, view);
                }
            });
#if DEBUG
            builder.Logging.AddDebug();
#endif

            //configuracion modulo de login
            builder.Services.AddSingleton<ILoginDataService, LoginDataService>();
            builder.Services.AddSingleton<ILoginPresenter, LoginPresenter>();
            builder.Services.AddSingleton<ILoginView, LoginPage>();
            //configuracion modulo de Register 
            builder.Services.AddSingleton<IRegisterDataService, RegisterDataService>();
            builder.Services.AddSingleton<IRegisterPresenter, RegisterPresenter>();
            builder.Services.AddSingleton<IRegisterView, RegisterPage>();
            //configuracion modulo de Products
            builder.Services.AddSingleton<IProductsDataService, ProductsDataService>();
            builder.Services.AddSingleton<IProductsPresenter, ProductsPresenter>();
            builder.Services.AddSingleton<IProductsView, ProductsPage>();
            //configuracion modulo de Orders
            builder.Services.AddSingleton<IOrdersDataService, OrderDataService>();
            builder.Services.AddSingleton<IOrdersPresenter, OrderPresenter>();
            builder.Services.AddSingleton<IOrdersView, OrderPage>();

            return builder.Build();
        }

        private static MauiAppBuilder AddServices(this MauiAppBuilder builder)
        {
            builder.Services.Configure<ConnectionStrings>(builder.Configuration.GetSection(nameof(ConnectionStrings)));
            //builder.Services.Configure<AppSettings>(builder.Configuration.GetSection(nameof(AppSettings)));
            builder.Services.AddSingleton<IConnectionString>(sp => sp.GetRequiredService<IOptions<ConnectionStrings>>().Value);
            builder.Services.AddSingleton<IHttpClientService, HttpClientService>();
            builder.Services.AddDbContext<DatabaseContextService>();
            var db = new DatabaseContextService();
            db.Database.EnsureCreated();
            db.Dispose();

            return builder;
        }


    }
}
