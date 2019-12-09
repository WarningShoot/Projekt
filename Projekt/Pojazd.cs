using System;
using System.Collections.Generic;
using System.Text;

namespace Projekt
{
    class Pojazd
    {
        public Pojazd(int iD_Pojazd, int kierowcy_ID, string marka, string model,
            int rocznik, string kolor, int liczbaMiejsc)
        {
            ID_Pojazd = iD_Pojazd;
            Kierowcy_ID = kierowcy_ID;
            Marka = marka;
            Model = model;
            Rocznik = rocznik;
            Kolor = kolor;
            LiczbaMiejsc = liczbaMiejsc;
        }

        public int ID_Pojazd { get; }
        public int Kierowcy_ID { get; set; }
        public string Marka { get; set; }
        public string Model { get; set; }
        public int Rocznik { get; set; }
        public string Kolor { get; set; }
        public int LiczbaMiejsc { get; set; }
    }
}
