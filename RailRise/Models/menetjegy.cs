using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RailRise.Models
{
    public class menetjegy
    {

        public string Honnan { get; set; }
        public string Hova { get; set; }
        public int ervenyes { get; set; }
        public int kocsiosztaly { get; set; }
        public string tol { get; set; }
        public string ig { get; set; }
        public string ar { get; set; }

        public menetjegy(string honnan, string hova, int Ervenyes, int Kocsiosztaly, string Tol, string Ig, string Ar)
        {
            Honnan = honnan;
            Hova = hova;
            ervenyes = Ervenyes;
            kocsiosztaly = Kocsiosztaly;
            tol = Tol;
            ig = Ig;
            ar = Ar;
        }

        public menetjegy()
        {
            Honnan = "Budapest";
            Hova = "Szolnok";
            ervenyes = 30;
            kocsiosztaly = 2;
            tol = "2019.10.01";
            ig = "2019.11.02";
            ar = "HUF 71200";
        }

      public string HonnanK()
        { return Honnan; }
        public string HovaK()
        { return Hova; }
        public int ervenyesK()
        { return ervenyes; }
        public int kocsiosztalyK()
        { return kocsiosztaly; }
        public string tolK()
        { return tol; }
        public string igK()
        { return ig; }

        public string arK()
        { return ar; }


    }
}
