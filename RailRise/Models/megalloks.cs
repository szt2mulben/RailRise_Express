using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RailRise.Models
{
    public class megalloks
    {
         
        public string Honnan { get; set; }
        public string Hova { get; set; }
        public DateTime Mikor { get; set; }
        public megalloks(string honnan, string hova, DateTime mikor)
        {
            Honnan = honnan;
            Hova = hova;
            Mikor = mikor;

        }

        public megalloks()
        {
            Honnan = string.Empty;
            Hova = string.Empty;
            Mikor = DateTime.Now;

        }

        public override string ToString()
        {
            Random rnd = new Random();
            return $"{Honnan} - {Hova} - ({String.Format("{0:yyyy.MM.dd.}", Mikor)}) \nJelenleg van ilyen járat.\nEbben az időben {rnd.Next(1,5)} megálló is van!";
        }
    }
}
