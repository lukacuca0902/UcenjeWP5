﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS
{
    internal class E08DoWhilePetlja
    {

        public static void Izvedi()
        {

            // u do while se obavezno ulazi barem jednom
            // radi s bool tipom podatka

            do{
                Console.WriteLine("Edunova");
            } while (false);

            while(false) Console.WriteLine("Osijek");


            Console.WriteLine("***********************");

            int i = 0;
            do
            {
                Console.WriteLine(i++);
            } while (i < 10);



            // sve ostalo vrijedi kao i za for i while









































        }
    }
}
