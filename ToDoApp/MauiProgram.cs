
using ToDoApp.ViewModel;
using ToDoApp.Views;

namespace ToDoApp;

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

        //Services
        builder.Services.AddSingleton(Connectivity.Current);

        //Views Registration
        builder.Services.AddSingleton<MainView>();
        builder.Services.AddSingleton<TaskDetailPage>();

        //ViewModels
        builder.Services.AddTransient<MainViewModel>();
        builder.Services.AddTransient<TaskDetailViewModel>();

        return builder.Build();

	}
}
