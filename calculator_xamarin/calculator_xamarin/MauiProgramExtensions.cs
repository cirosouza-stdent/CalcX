using calculator_xamarin.Views;

namespace calculator_xamarin;

public static class MauiProgramExtensions
{
    public static MauiAppBuilder UseSharedMauiApp(this MauiAppBuilder builder)
    {
        builder
            .UseMauiApp<App>();

        // TODO: Add the entry points to your Apps here.
        // See also: https://learn.microsoft.com/dotnet/maui/fundamentals/app-lifecycle
        builder.Services.AddTransient<AppShell, AppShell>();


        return builder;
    }
}
