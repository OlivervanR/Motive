using Microsoft.Extensions.Logging;

namespace Test;

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
				fonts.AddFont("Kiona-Itallic.ttf", "OpenSansKiona");
				fonts.AddFont("Astro World.tff", "OpenSansAstro");
				fonts.AddFont("coolvetica rg.otf", "OpenSansCoolvetica");
				fonts.AddFont("Akira Expanded Demo.otf", "Akira");
				fonts.AddFont("Aventi-Regular.ttf", "Aventi");
				fonts.AddFont("Micker.otf","Micker");
				fonts.AddFont("Rounded_Elegance.ttf","R-Elegance");
				fonts.AddFont("Garet-Book.otf","Garet");
				fonts.AddFont("TT Fors Trial Regular.ttf","TT Fors");
				fonts.AddFont("RenogareSoft-Regular.ttf","Renogare");
				fonts.AddFont("TT Drugs Trial Regular.otf","TT Drugs");
				
            })
			.UseMauiMaps();

#if DEBUG
		builder.Logging.AddDebug();
#endif

		return builder.Build();
	}
}
