namespace MoncayoJorge_ExamenP2;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();
        Routing.RegisterRoute(nameof(Views.NotePage), typeof(Views.NotePage));
    }
}
