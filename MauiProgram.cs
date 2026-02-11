using AppShoppingCenter.Services;
using AppShoppingCenter.Storages;
using CommunityToolkit.Maui;
using Microsoft.Extensions.Logging;

namespace AppShoppingCenter
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .UseMauiCommunityToolkit()
                .UseMauiCommunityToolkitMediaElement()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Light.ttf", "OpenSansLight");
                    fonts.AddFont("OpenSans-Bold.ttf", "OpenSandBold");
                });
            builder.Services.AddSingleton<StoreService>();
            builder.Services.AddSingleton<RestaurantService>();
            builder.Services.AddSingleton<CinemaService>();
            builder.Services.AddSingleton<TicketService>();
            builder.Services.AddSingleton<TicketPreferenceStorage>();

#if DEBUG
            builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}
