using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.CompilerServices;
using System.Windows.Input;

namespace RailRise_Express.ViewModels
{
    public class RailRise : INotifyPropertyChanged
    {
        private string startLocation;
        private string endLocation;
        private DateTime departureDate;

        public string StartLocation
        {
            get { return startLocation; }
            set
            {
                startLocation = value;
                OnPropertyChanged();
            }
        }

        public string EndLocation
        {
            get { return endLocation; }
            set
            {
                endLocation = value;
                OnPropertyChanged();
            }
        }

        public DateTime DepartureDate
        {
            get { return departureDate; }
            set
            {
                departureDate = value;
                OnPropertyChanged();
            }
        }

        public ICommand SearchCommand { get; }

        public RailRise()
        {
            SearchCommand = new RelayCommand(SearchRoute);
        }

        private void SearchRoute()
        {
            
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

    }
}
