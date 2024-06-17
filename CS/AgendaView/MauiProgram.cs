using DevExpress.Maui;

namespace AgendaView;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.UseDevExpress()
			.UseDevExpressScheduler()
			.UseDevExpressCollectionView()
			.UseDevExpressControls()
			.UseDevExpressEditors()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
			});

		return builder.Build();
	}
}
