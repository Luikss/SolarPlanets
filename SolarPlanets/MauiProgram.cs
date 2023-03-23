namespace SolarPlanets;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("Montserrant-Medium.ttf", "RegularFont");
				fonts.AddFont("Montserrant-SemiBold.ttf", "MediumFont");
                fonts.AddFont("Montserrant-Bold.ttf", "BoldFont");
            });

		return builder.Build();
	}
}
