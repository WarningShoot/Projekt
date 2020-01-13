using System;
using System.Collections.Generic;
using System.Text;

namespace Projekt
{
    public class Przejazd
    {
        public Przejazd(int iD_Przejazd, Pojazd pojazd, Wynagrodzenie wynagrodzenie, Konto_Kierowcy kierowcy,
            AdresDostawy adresDostawy, AdresOdbioru adresOdbioru, Opłaty opłaty, DateTime date,
            decimal wysokoscWynagrodenia, decimal dystans, decimal napiwek, string rodzaj)
        {
            ID_Przejazd = iD_Przejazd;
            Pojazd = pojazd;
            Wynagrodzenie = wynagrodzenie;
            Kierowcy = kierowcy;
            AdresDostawy = adresDostawy;
            AdresOdbioru = adresOdbioru;
            Opłaty = opłaty;
            Date = date;
            WysokoscWynagrodenia = wysokoscWynagrodenia;
            Dystans = dystans;
            Napiwek = napiwek;
            Rodzaj = rodzaj;
        }

        public int ID_Przejazd { get; }
        public Pojazd Pojazd { get; set; }
        public Wynagrodzenie Wynagrodzenie { get; set; }
        public Konto_Kierowcy Kierowcy { get; set; }
        public AdresDostawy AdresDostawy { get; set; }
        public AdresOdbioru AdresOdbioru { get; set; }
        public Opłaty Opłaty { get; set; }
        public DateTime Date { get; set; }
        public decimal WysokoscWynagrodenia { get; set; } = .00M;
        public decimal Dystans { get; set; } = .000M;
        public decimal Napiwek { get; set; } = .00M;
        public string Rodzaj { get; set; }
    }
}
