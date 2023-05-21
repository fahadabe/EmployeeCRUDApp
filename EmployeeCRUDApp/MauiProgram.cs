using CommunityToolkit.Maui;

namespace EmployeeCRUDApp;
public static class MauiProgram
{
    public static MauiApp CreateMauiApp()
    {
        var builder = MauiApp.CreateBuilder();
        builder.UseMauiApp<App>().ConfigureFonts(fonts =>
        {
            fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
            fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
        }).UseMauiCommunityToolkit();

        builder.Services.AddSingleton<IDatabase, Database>();
        builder.Services.AddSingleton<IEmployeeService, EmployeeService>();

        builder.Services.AddTransient<EmployeeViewModel>();
        builder.Services.AddTransient<EmployeeDetailsViewModel>();
        builder.Services.AddTransient<NewEmployeeViewModel>();

        builder.Services.AddTransient<EmployeesPage>();
        builder.Services.AddTransient<EmployeeDetailsPage>();
        builder.Services.AddTransient<NewEmployeePage>();
        return builder.Build();
    }
}