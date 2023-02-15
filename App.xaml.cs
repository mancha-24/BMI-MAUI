using BMI_MAUI.MVVM.Views;

namespace BMI_MAUI;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		MainPage = new BMIView();
	}
}
