using BMI_MAUI.MVVM.ViewModels;

namespace BMI_MAUI.MVVM.Views;

public partial class BMIView : ContentPage
{
	public BMIView()
	{
		InitializeComponent();
		BindingContext = new BMIViewModel();
	}
}