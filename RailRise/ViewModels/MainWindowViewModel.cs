using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using RailRise.ViewModels.Base;

namespace RailRise.ViewModels
{
    public partial class MainWindowViewModel : BaseViewModel
    {
        [ObservableProperty]
        private BaseViewModel _childViewModel;

        [ObservableProperty]
        private string _statusBarText = "A program betölödött...";

        public MainWindowViewModel()
        {
            _childViewModel = new WelcomeViewModel();
        }

        [RelayCommand]
        private void ShowMegallokView()
        {
            ChildViewModel = new MegallokViewModel();
            StatusBarText = "Megállók és állomások információi";
        }

        [RelayCommand]
        private void ShowMenetjegyView()
        {
            ChildViewModel = new MenetrendViewModel();
            StatusBarText = "Menetjegy";
        }

    }
}
