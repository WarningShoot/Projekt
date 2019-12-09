using System;
using System.Collections.Generic;
using System.Text;

namespace Projekt
{
    class Wynagrodzenie
    {
        public Wynagrodzenie(int iD_Wynagrodznie, int kierowcy_ID,
            DateTime data,
            decimal wyplataBrutto, decimal wyplataNetto,
            decimal podatekDochodowy, decimal skladkaZUS)
        {
            ID_Wynagrodznie = iD_Wynagrodznie;
            Kierowcy_ID = kierowcy_ID;
            Data = data;
            WyplataBrutto = wyplataBrutto;
            WyplataNetto = wyplataNetto;
            PodatekDochodowy = podatekDochodowy;
            SkladkaZUS = skladkaZUS;
        }

        public int ID_Wynagrodznie { get; }
        public int Kierowcy_ID { get; set; }
        public DateTime Data { get; set; }
        public decimal WyplataBrutto { get; set; } = .00M;
        public decimal WyplataNetto { get; set; } = .00M;
        public decimal PodatekDochodowy { get; set; } = .00M;
        public decimal SkladkaZUS { get; set; } = .00M;
    }
}
