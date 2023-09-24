using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RailRise_Express.Model
{
    public class Rail
    {
        public string StartLocation { get; set; }
        public string EndLocation { get; set; }
        public DateTime DepartureTime { get; set; }
        public DateTime ArrivalTime { get; set; }
        public int Duration { get; set; }

        public Rail(string startLocation, string endLocation, DateTime departureTime, DateTime arrivalTime, int duration)
        {
            StartLocation = startLocation;
            EndLocation = endLocation;
            DepartureTime = departureTime;
            ArrivalTime = arrivalTime;
            Duration = duration;
        }  
        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }

            Rail otherRail = (Rail)obj;

            return StartLocation == otherRail.StartLocation &&
                   EndLocation == otherRail.EndLocation &&
                   DepartureTime == otherRail.DepartureTime &&
                   ArrivalTime == otherRail.ArrivalTime &&
                   Duration == otherRail.Duration;
        }

        public override int GetHashCode()
        {
            unchecked
            {
                int hash = 17;
                hash = hash * 23 + StartLocation.GetHashCode();
                hash = hash * 23 + EndLocation.GetHashCode();
                hash = hash * 23 + DepartureTime.GetHashCode();
                hash = hash * 23 + ArrivalTime.GetHashCode();
                hash = hash * 23 + Duration.GetHashCode();
                return hash;
            }
        }
    }
}
