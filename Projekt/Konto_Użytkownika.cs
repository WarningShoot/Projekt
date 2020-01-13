using System;
using System.Collections.Generic;
using System.Text;

namespace Projekt
{
    public class Konto_Użytkownika
    {
        public Konto_Użytkownika(int użytkownik_ID, string imie, string nazwisko,
            string email, string haslo, string numerKartKred, string numerTelefonu)
        {
            Użytkownik_ID = użytkownik_ID;
            Imie = imie;
            Nazwisko = nazwisko;
            Email = email;
            Haslo = haslo;
            NumerKartKred = numerKartKred;
            NumerTelefonu = numerTelefonu;
        }

        public int Użytkownik_ID { get; set; }
        public string Imie { get; set; }
        public string Nazwisko { get; set; }
        public string Email { get; set; }
        public string Haslo { get; set; }
        public string NumerKartKred { get; set; }
        public string NumerTelefonu { get; set; }
    }
}
