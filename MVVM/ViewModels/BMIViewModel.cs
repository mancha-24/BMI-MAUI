using BMI_MAUI.MVVM.Models;

namespace BMI_MAUI.MVVM.ViewModels
{
    public class BMIViewModel
    {
        public BMI BMI { get; set; }

        public BMIViewModel()
        {
            BMI= new BMI();
            BMI.Height = 180;
            BMI.Weight = 73;
        }
    }
}
