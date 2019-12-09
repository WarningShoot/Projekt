using System;
using System.Collections.Generic;
using System.Text;

namespace Projekt
{
    class Przejazd
    {
        public Przejazd(
            int iD_Przejazd,
            int pojazd_ID,
            int wynagrodzenie_ID,
            int kierowcy_ID,
            int adresDostawy_ID,
            int adresOdbioru_ID,
            int oplaty_ID, DateTime date,
            decimal wysokoscWynagrodenia,
            decimal dystans,
            decimal napiwek, 
            string rodzaj)

        {
            ID_Przejazd = iD_Przejazd;
            Pojazd_ID = pojazd_ID;
            Wynagrodzenie_ID = wynagrodzenie_ID;
            Kierowcy_ID = kierowcy_ID;
            AdresDostawy_ID = adresDostawy_ID;
            AdresOdbioru_ID = adresOdbioru_ID;
            Oplaty_ID = oplaty_ID;
            Date = date;
            WysokoscWynagrodenia = wysokoscWynagrodenia;
            Dystans = dystans;
            Napiwek = napiwek;
            Rodzaj = rodzaj;
        }

        public int ID_Przejazd { get; }
        public int Pojazd_ID { get; set; }
        public int Wynagrodzenie_ID { get; set; }
        public int Kierowcy_ID { get; set; }
        public int AdresDostawy_ID { get; set; }
        public int AdresOdbioru_ID { get; set; }
        public int Oplaty_ID { get; set; }
        public DateTime Date { get; set; }
        public decimal WysokoscWynagrodenia { get; set; } = .00M;
        public decimal Dystans { get; set; } = .000M;
        public decimal Napiwek { get; set; } = .00M;
        public string Rodzaj { get; set; }
    }
}
