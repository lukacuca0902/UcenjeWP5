﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS
{
    internal class E09ForeachPetlja
    {

        public static void Izvedi()
        {

            string grad = "Osijek";


            // svaki znak tog grada ispisati jedno ispod drugog

            for (int i = 0; i < grad.Length; i++)
            {
                Console.WriteLine(grad[i]);
            }

            Console.WriteLine("******************");

            foreach(char znak in grad)
            {
                Console.WriteLine(znak);
            }

            Console.WriteLine("******************");

            // e = entitity, element uglavnom u programiranju


            float[] brojevi = { 2, 3, 4, 5.3f, 3, 3, 2, 2 };
            float suma = 0;   
            foreach(var e in brojevi)
            {
                Console.WriteLine(e);
                suma += e;
            }

            Console.WriteLine(suma);




























        }
    }
}
