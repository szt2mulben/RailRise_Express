using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using RailRise_Express.Model;
using System.DirectoryServices;

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

        public ICommand Delete { get; }
        public ICommand SearchCommand { get; }

        public RailRise()
        {
            SearchCommand = new RelayCommand(SearchRoute);
            Delete = new RelayCommand(DoRemove);
        }

        private void DoRemove()
        {
            throw new NotImplementedException();
        }

        private void SearchRoute()
        {
            //Itt fog menni a keresés, csak nincs még semmi olyan, amivel tudnánk keresni.
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

    }
}
