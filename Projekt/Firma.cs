using System;
using System.Collections.Generic;
using System.Text;

namespace Projekt
{
    public class Firma
    {
        public Firma(int firma_ID, string nazwaFirmy, string numerNIP, AdresFirmy adresFirmy)
        {
            Firma_ID = firma_ID;
            NazwaFirmy = nazwaFirmy;
            NumerNIP = numerNIP;
            AdresFirmy = adresFirmy;
        }

        public int Firma_ID { get; set; }
        public string NazwaFirmy { get; set; }
        public string NumerNIP { get; set; }
        public AdresFirmy AdresFirmy { get; set; }
    }
}
