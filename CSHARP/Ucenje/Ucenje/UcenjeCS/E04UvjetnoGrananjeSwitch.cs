using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS
{
    internal class E04UvjetnoGrananjeSwitch
    {
        public static void Izvedi()
        {


            // switch je višestruko grananje

            int i = 0;

            switch (i)
            {
                case 0:
                    Console.WriteLine("Dobar");
                    break;

                case 1:
                    Console.WriteLine("Loš");
                    break;
                case 2:
                    Console.WriteLine("Zao");
                    break;
                case 3:
                    Console.WriteLine("Ostalo");
                    break;

            }

            // switch radi s int, string i char i drugi

            char znak = '@';

            Console.WriteLine(znak);
            Console.WriteLine((int) znak);

















        }



    }
}
