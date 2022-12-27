using ColorPicker.MVVM.ViewModels;

namespace ColorPicker.MVVM.Views;

public partial class ColorView : ContentPage
{
	public ColorView()
	{
		InitializeComponent();

		BindingContext = new ColorVM();
    }
}