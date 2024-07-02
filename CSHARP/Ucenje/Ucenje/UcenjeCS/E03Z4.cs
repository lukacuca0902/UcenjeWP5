using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS
{
    internal class E03Z4
    {

        public static void Izvedi()
        {


            Console.Write("Upiši prvi cijeli broj ");
            int i = int.Parse(Console.ReadLine());

            Console.Write("Upiši drugi cijeli broj ");
            int j = int.Parse(Console.ReadLine());

            Console.Write("Upiši prvi cijeli broj ");
            int x = int.Parse(Console.ReadLine());



            int najmanji = i;

            if (j < najmanji)
            {
                najmanji = j;

            }

            if (x < najmanji)
            {
                x = najmanji;

            }

            Console.WriteLine("Najmanji uneseni broj : " +najmanji);


        }






    }
}
