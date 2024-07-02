using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS
{
    internal class E03Z1
    {

        // Program od korisnika trazi unos broj godina koji ima korisnik
        // Program ispisuje da li je korisnik stariji od 18
        // dodatno ako je unos ispod nula godine ili iznad 100 godina ispisati greška
        public static void Izvedi()
        {
            
            Console.Write("Upiši koliko imaš godina: ");
            
            int i = int.Parse(Console.ReadLine());

            if (i >= 18)
            {
                Console.WriteLine("Punoljetan si");
            }
            else
            {
                Console.WriteLine("Nisi punoljetan");
            }

            if (i<0 || i>100)
            {
                Console.WriteLine("Greška");
            }
               


        }





    }
}
