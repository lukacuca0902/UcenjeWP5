using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS
{
    internal class E03UvjetnoGrananjeIf
    {




        public static void Izvedi()
        {

            int i = 7; // Ovo simuliram da je korisnik pomoću int.parse CR učitao vrijednost

            bool uvjet = i == 8;

            Console.WriteLine(uvjet);

            // if radi s bool tipom podatka

            if (uvjet) {
                Console.WriteLine("Vrijednost varijable i je 8 ");

            }

            // ovo nikada ne pisati
            if (uvjet == true) { 
            
            
            }


            // najčešća sintaksa
            if(i == 8)
            {


            }

            // if ima i else granu
            if (1 > 10)
            {
                Console.WriteLine("i je veći od 10 ");
            }

            else
            {
                Console.WriteLine("i nije veći od 10");
            }


            // if ne mora imati {}, ako se if ili else odnose samo na jednu liniju
            // ovo nije najbolja praksa. Best practice
            if(i>10) Console.WriteLine("i je veći od 10");
            else Console.WriteLine("i nije veći od 10");


            // puna sintaksa if naredbe

            int b = 2;
            if (b == 1) {
                Console.WriteLine("Ne moze");
            }

            else if (b>5)
            {
                Console.WriteLine("OK");
            }
            // još moze ici nn else if 
            else
            {
                Console.WriteLine("ostalo");
            }


        

        // operatori & i &&
        // & uvijek provjerava oba uvjeta
        // && ukoliko 1. uvjet nije zadovoljen, drugi se ne gleda
        int x = 2, y = 1;
        
        if (x == 1 && y == 1)
            {
                Console.WriteLine("x i y su 1");
            }
            // operatori | i || (or) altgr + W


            // | provjerava oba uvjeta
            // || ukoliko je prvi uvjet zadovoljen, drugi se ne gleda

            if (x>1 || y==0)
            {
                Console.WriteLine("Ako je prvi uvjet zadovoljen ulazi se u if");

            }


            // if se moze gnijezditi

            if ( x == 3)
            {
                int k = 9;
                if (y > 0)
                {
                    Console.WriteLine("Zadovoljeno");
                }

            }

            // inline if - tercijarni operator ? :

            x = 0;
            if (x==0)
            {
                Console.WriteLine("OK");
            }
            else
            {
                Console.WriteLine("NE");
            }

            //preduvjet je da if i else provode istu akciju - u ovom slučaju cw

            Console.WriteLine(x==0 ? "OK" : "NE");









        }









}
}
