using System;
using System.Collections.Generic;
using System.Text;

namespace Projekt
{
    public class Opłaty
    {
        public Opłaty(int iD_Oplaty, DateTime date, Konto_Użytkownika użytkownik,
            decimal wartosc, string metodaPlatnosci)
        {
            ID_Oplaty = iD_Oplaty;
            Użytkownik = użytkownik;
            Date = date;
            Wartosc = wartosc;
            MetodaPlatnosci = metodaPlatnosci;
        }

        public int ID_Oplaty { get; }
        public Konto_Użytkownika Użytkownik { get; set; }
        public DateTime Date { get; set; }
        public decimal Wartosc { get; set; } = .00M;
        public string MetodaPlatnosci { get; set; }
    }
}
