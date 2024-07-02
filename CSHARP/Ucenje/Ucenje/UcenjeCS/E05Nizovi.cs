using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS
{
    internal class E05Nizovi
    {

        public static void Izvedi()
        {

            // Motivacija : Treba ti 12 varijbali za 12 temperatura različitih mjeseci
            // Ono što znamo
            
            int temp1, temp2, t3, t4; // -> Ovo je loše

            // eng. Arrays
            // Arrays = Polja
            //jednodimenzionalni nizovi
            // [ altgr + F i + G ]
            // Najveći problem nizova je što na početku moram znati koliko ima elemenata

            int[] temperature = new int[12];

            // nizovi počinju s indexom 0
            // prvi element niza je na indexu 0
            temperature[0] = -2; // siječanj
            temperature[1] = 0;
            //..
            temperature[11] = -3; // Prosinac

            // duzina niza
            Console.WriteLine(temperature.Length); // ukupan broj elemenata

            // zadnji se u pravilu ovako postavlja
            temperature[temperature.Length - 1] = 0;

            Console.WriteLine(temperature[1]);

            // temperature[12] = 1; - Greška prilikom izvođenja

            // ispis svih elemenata niza
            Console.WriteLine(string.Join(",",temperature));


            // skraćeniji način
            int[] niz = { 2, 3, 4, 5, 56, 6, 3, 3 };

            // ispisati 56
            Console.WriteLine(niz[4]);

            string[] gradovi = { "Osijek", "Donji Miholjac", "Valpovo", "Belisce" };

            // ispisati zadnji grad
            Console.WriteLine(gradovi[gradovi.Length-1]);



            int[,] tablica = {
            {1,2,3 },
            {4,5,6 },
            { 7,8,9}
            };


            // ispiši 6
            // ispiši 9

            Console.WriteLine(tablica[1,2]);
            Console.WriteLine(tablica[2, 2]);


            // trodimenzionalni niz

            int[,,] kocka = { };

            // tesaarect - 4 dimenzije

            int[,,,] tesaarect = { };

            // multiverse
            int[,,,,,,] multiverse = { };


            //nizovi mogu imati i razlicite tipove podataka

            object[] objekti = {"ovo", 3, 2.6, true};










        }















    }
}
