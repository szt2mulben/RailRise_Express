using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace RailRise_Express.ViewModels
{
    public class Map : INotifyPropertyChanged
    {
        private string mapUrl;

        public string MapUrl
        {
            get { return mapUrl; }
            set
            {
                if (mapUrl != value)
                {
                    mapUrl = value;
                    OnPropertyChanged();
                }
            }
        }
        public Map()
        {
            // Itt állíthatod be a kezdeti térkép URL-t vagy címeket, koordinátákat.
            MapUrl = "https://www.google.com/maps";
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }


}
