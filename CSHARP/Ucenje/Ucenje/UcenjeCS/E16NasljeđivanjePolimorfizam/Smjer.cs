using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS.E16NasljeđivanjePolimorfizam
{
    internal class Smjer : Entitet // Klasa smjer nasljeđuje javna i zasticena svojstva i metode klase Entitet
    {
        public string? Naziv { get; set; }

        public override string ToString()
        {
            return  Naziv;
        }
    }
}
