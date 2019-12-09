using System;
using System.Collections.Generic;
using System.Text;

namespace Projekt
{
    class Opłaty
    {
        public Opłaty(int iD_Oplaty, DateTime date, 
            decimal wartosc, string metodaPlatnosci)
        {
            ID_Oplaty = iD_Oplaty;
            Date = date;
            Wartosc = wartosc;
            MetodaPlatnosci = metodaPlatnosci;
        }

        public int ID_Oplaty { get; }
        public DateTime Date { get; set; }
        public decimal Wartosc { get; set; } = .00M;
        public string MetodaPlatnosci { get; set; }
    }
}
