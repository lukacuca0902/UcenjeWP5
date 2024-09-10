using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS
{
    internal class EO1Z3
    {

        public static void Izvedi()
        {
            // Program od korisnika učitava ime grada i broj stanovnika
            // Ispisuje rečenicu : U xxxx zivi xxxx ljudi

          
            Console.WriteLine("Unesi ime grada : ");
            var grad = Console.ReadLine();  

            Console.WriteLine("Unesi broj stanovnika : ");
            int bs=int.Parse(Console.ReadLine());


            Console.WriteLine("U {0} zivi {1} ljudi",grad,bs);


            // Osigurati da se upise grad
            // Osigurati da se upise broj stanovnika kao broj







        }
    }
}
