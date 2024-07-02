using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS
{
    internal class E03Z2
    {


        // Program od korisnika trazi unos cijelog broja, paran ili ne
        public static void Izvedi()
        {
            /*
                        Console.Write("Upiši jedan cijeli broj ");

                        int i = int.Parse(Console.ReadLine());

                        if (i % 2 == 0)
                        {
                            Console.WriteLine("Paran");
                        }
                        else
                        {
                            Console.WriteLine("Nije paran");
                        }
            */


            // inline if - tercijarni operator ? :
            Console.Write("Upiši jedan cijeli broj ");

            int i = int.Parse(Console.ReadLine());

            Console.WriteLine(i % 2 == 0 ? "Paran" : "Nije paran");














        }







    }
}
