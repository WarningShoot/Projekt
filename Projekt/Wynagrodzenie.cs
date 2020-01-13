using System;
using System.Collections.Generic;
using System.Text;

namespace Projekt
{
    public class Wynagrodzenie
    {
        public Wynagrodzenie(int iD_Wynagrodznie, Konto_Kierowcy kierowca, Firma firma,
            DateTime data,
            decimal wyplataBrutto, decimal wyplataNetto,
            decimal podatekDochodowy, decimal skladkaZUS)
        {
            ID_Wynagrodznie = iD_Wynagrodznie;
            Kierowca = kierowca;
            Firma = firma;
            Data = data;
            WyplataBrutto = wyplataBrutto;
            WyplataNetto = wyplataNetto;
            PodatekDochodowy = podatekDochodowy;
            SkladkaZUS = skladkaZUS;
        }

        public int ID_Wynagrodznie { get; }
        public Konto_Kierowcy Kierowca { get; set; }
        public Firma Firma { get; set; }
        public DateTime Data { get; set; }
        public decimal WyplataBrutto { get; set; } = .00M;
        public decimal WyplataNetto { get; set; } = .00M;
        public decimal PodatekDochodowy { get; set; } = .00M;
        public decimal SkladkaZUS { get; set; } = .00M;
    }
}
