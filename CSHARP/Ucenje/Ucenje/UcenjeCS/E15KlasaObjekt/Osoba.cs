using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS.E15KlasaObjekt
{
    // Klasa je opisnik objekta - OVO NAUČITI NAPAMET
    internal class Osoba
    {

        //klasa sadrzi svojstva (property)
        public int? Sifra { get; set; } //OOP princip učahurivanja

        public string? Ime { get; set; } // ? označava kako Ime moze biti null

        public string? Prezime { get; set; }

        public Mjesto? Mjesto { get; set; }



        //klasa sadrzi metode
        public string ImePrezime()
        {
            return Ime + " " + Prezime;
        }
    }
}
