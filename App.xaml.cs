using ColorPicker.MVVM.Views;

namespace ColorPicker;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		MainPage = new ColorView();
	}
}
