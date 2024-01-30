using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using RailRise.Models;
using RailRise.ViewModels.Base;
using RailRise.Views;
using System;
using System.Collections.ObjectModel;

namespace RailRise.ViewModels
{
    public partial class MegallokViewModel : BaseViewModel
    {

        [ObservableProperty]
        private ObservableCollection<megalloks> _students = new ObservableCollection<megalloks>();

        [ObservableProperty]
        private megalloks _selectedStudent;


        public MegallokViewModel()
        {
            SelectedStudent = new megalloks();
        }

        [RelayCommand]
        public void DoSave(megalloks newmegallo)
        {
            Students.Add(newmegallo);
            OnPropertyChanged(nameof(Students));
        }

        [RelayCommand]
        void DoNewStudent()
        {
            SelectedStudent = new megalloks();
        }

        [RelayCommand]
        public void DoRemove(megalloks delete)
        {
            Students.Remove(delete);
            OnPropertyChanged(nameof(Students));
        }
    }
}
