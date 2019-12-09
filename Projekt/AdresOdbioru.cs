using System;
using System.Collections.Generic;
using System.Text;

namespace Projekt
{
    class AdresOdbioru
    {
        public AdresOdbioru(int adresOdbioru_ID, string ulica, string numerDomu,
            string numerMieszkania, string kodPocztowy, string miasto)
        {
            AdresOdbioru_ID = adresOdbioru_ID;
            Ulica = ulica;
            NumerDomu = numerDomu;
            NumerMieszkania = numerMieszkania;
            KodPocztowy = kodPocztowy;
            Miasto = miasto;
        }

        public int AdresOdbioru_ID { get; }
        public string Ulica { get; set; }
        public string NumerDomu { get; set; }
        public string NumerMieszkania { get; set; }
        public string KodPocztowy { get; set; }
        public string Miasto { get; set; }
    }
}
