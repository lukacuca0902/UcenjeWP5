using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS
{
    internal class EO3Z4
    {

        public static void Izvedi()
        {


            Console.WriteLine("Unesi ime grada :");
            var grad = Console.ReadLine();


/*
            if (grad == "Osijek")
            {

                Console.WriteLine("Slavonija");

            }


            else if (grad == "Zadar")
            {
                Console.WriteLine("Dalmacija");
            }


            else if (grad == "Čakovec")
            {
                Console.WriteLine("Međimurje");
            }

            else if (grad == "Pula")
            {
                Console.WriteLine("Istra");
            }

            else
            {
                Console.WriteLine("Ne znam koja je regija");
            }
*/
            int i = 0;

            switch (i)
            {
                case 0:
                    Console.WriteLine("Slavonija");
                    break;

                case 1:
                    Console.WriteLine("Dalmacija");
                    break;
                case 2:
                    Console.WriteLine("Međimurje");
                    break;
                case 3:
                    Console.WriteLine("ne znam koja je regija");
                    break;

            }











        }
    }
}
