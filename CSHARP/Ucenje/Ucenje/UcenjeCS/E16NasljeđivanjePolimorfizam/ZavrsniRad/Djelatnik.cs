using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS.E16NasljeđivanjePolimorfizam.ZavrsniRad
{
    internal class Djelatnik
    {
        public int? IdDjelatnik { get; set; }
        public string? Frizura { get; set; }
        public DateTime? Termin { get; set; }
        public string? Korisnik { get; set; }

        public Djelatnik(int idDjelatnik, string frizura, DateTime termin, string korisnik) 
        {  
         IdDjelatnik = idDjelatnik;
         Frizura = frizura;
         Termin = termin;     
         Korisnik = korisnik;
        }
    }
}
