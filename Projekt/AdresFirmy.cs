using System;
using System.Collections.Generic;
using System.Text;

namespace Projekt
{
    public class AdresFirmy
    {
        public AdresFirmy(int adresFirmy_ID, string ulica, string numerDomu,
            string numerMieszkania, string kodPocztowy, string miasto)
        {
            AdresFirmy_ID = adresFirmy_ID;
            Ulica = ulica;
            NumerDomu = numerDomu;
            NumerMieszkania = numerMieszkania;
            KodPocztowy = kodPocztowy;
            Miasto = miasto;
        }

        public int AdresFirmy_ID { get; set; }
        public string Ulica { get; set; }
        public string NumerDomu { get; set; }
        public string NumerMieszkania { get; set; }
        public string KodPocztowy { get; set; }
        public string Miasto { get; set; }
    }
}
