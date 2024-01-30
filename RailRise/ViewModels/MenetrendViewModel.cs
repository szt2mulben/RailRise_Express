using CommunityToolkit.Mvvm.ComponentModel;
using RailRise.Models;
using RailRise.ViewModels.Base;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RailRise.ViewModels
{
    public partial class MenetrendViewModel : BaseViewModel
    {
        [ObservableProperty]
        private ObservableCollection<menetjegy> _students = new ObservableCollection<menetjegy>();

        [ObservableProperty]
        private menetjegy _selectedStudent;


        public MenetrendViewModel()
        {
            SelectedStudent = new menetjegy();
        }

    }
}
