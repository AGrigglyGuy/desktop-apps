using System;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace Calculator.ViewModels
{
    public partial class MainWindowViewModel : ViewModelBase
    {
        [ObservableProperty]
        private string display = "0";

        // Code for the number and decimal point buttons
        [RelayCommand]
        private void MainButtons(string button)
        {
            if (string.IsNullOrEmpty(button))
            {
                return;
            }
            if (button == ".")
            {
                Display += ".";
            }
            if (Display == "0")
            {
                Display = button;
            }
            else
            {
                Display += button;
            }
        }
    }
}
