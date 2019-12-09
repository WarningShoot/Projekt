using System;

namespace Projekt
{
    public class Kierowcy
    {
        public Kierowcy(int iD_Kierowcy, int adresKierowcy_ID, string imie,
            string nazwisko, string pesel, string numerDowodu,
            string numerTelefonu, string plec, decimal saldoKierowcy)
        {
            ID_Kierowcy = iD_Kierowcy;
            AdresKierowcy_ID = adresKierowcy_ID;
            Imie = imie;
            Nazwisko = nazwisko;
            Pesel = pesel;
            NumerDowodu = numerDowodu;
            NumerTelefonu = numerTelefonu;
            Plec = plec;
            SaldoKierowcy = saldoKierowcy;
        }

        public int ID_Kierowcy { get; }
        public int AdresKierowcy_ID { get; set; }
        public string Imie { get; set; }
        public string Nazwisko { get; set; }
        public string Pesel { get; set; }
        public string NumerDowodu { get; set; }
        public string NumerTelefonu { get; set; }
        public string Plec { get; set; }
        public decimal SaldoKierowcy { get; set; } = .00M;

    }
}
