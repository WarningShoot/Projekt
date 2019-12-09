using System;
using System.Collections.Generic;
using System.Text;

namespace Projekt
{
    class AdresKierowcy
    {
        public AdresKierowcy(int iD_AdresKierwocy, string ulica, string numerDomu,
            string numerMieszkania, string kodPocztowy, string miasto)
        {
            ID_AdresKierwocy = iD_AdresKierwocy;
            Ulica = ulica;
            NumerDomu = numerDomu;
            NumerMieszkania = numerMieszkania;
            KodPocztowy = kodPocztowy;
            Miasto = miasto;
        }

        public int ID_AdresKierwocy { get; }
        public string Ulica { get; set; }
        public string NumerDomu { get; set; }
        public string NumerMieszkania { get; set; }
        public string KodPocztowy { get; set; }
        public string Miasto { get; set; }
    }
}
