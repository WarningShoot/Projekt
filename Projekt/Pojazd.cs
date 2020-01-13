using System;
using System.Collections.Generic;
using System.Text;

namespace Projekt
{
    public class Pojazd
    {
        public Pojazd(int iD_Pojazd, Konto_Kierowcy kierowca, string marka, string model,
            int rocznik, string kolor, int liczbaMiejsc)
        {
            ID_Pojazd = iD_Pojazd;
            Kierowca = kierowca;
            Marka = marka;
            Model = model;
            Rocznik = rocznik;
            Kolor = kolor;
            LiczbaMiejsc = liczbaMiejsc;
        }

        public int ID_Pojazd { get; }
        public Konto_Kierowcy Kierowca { get; set; }
        public string Marka { get; set; }
        public string Model { get; set; }
        public int Rocznik { get; set; }
        public string Kolor { get; set; }
        public int LiczbaMiejsc { get; set; }
    }
}
