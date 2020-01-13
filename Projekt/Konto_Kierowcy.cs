using System;
using System.Collections.Generic;

namespace Projekt
{
    public class Konto_Kierowcy
    {
        public Konto_Kierowcy(int iD_Kierowcy, AdresKierowcy adresKierowcy, string imie, string nazwisko,
            string pesel, string numerDowodu, string numerTelefonu, string plec, decimal saldoKierowcy, List<Pojazd> pojazdy)
        {
            ID_Kierowcy = iD_Kierowcy;
            AdresKierowcy = adresKierowcy;
            Imie = imie;
            Nazwisko = nazwisko;
            Pesel = pesel;
            NumerDowodu = numerDowodu;
            NumerTelefonu = numerTelefonu;
            Plec = plec;
            SaldoKierowcy = saldoKierowcy;
            Pojazdy = pojazdy;
        }

        public int ID_Kierowcy { get; }
        public AdresKierowcy AdresKierowcy { get; set; }
        public string Imie { get; set; }
        public string Nazwisko { get; set; }
        public string Pesel { get; set; }
        public string NumerDowodu { get; set; }
        public string NumerTelefonu { get; set; }
        public string AdresEmail { get; set; }
        public string Plec { get; set; }
        public string Haslo { get; set; }
        public decimal SaldoKierowcy { get; set; } = .00M;

        public List<Pojazd> Pojazdy = new List<Pojazd>();
    }
}
