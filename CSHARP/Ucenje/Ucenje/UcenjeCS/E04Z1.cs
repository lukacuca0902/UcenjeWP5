using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS
{
    internal class E04Z1
    {


        //Korisnik unosi brojčanu vrijednost ocjene od 1 do 5
        //Korisnik ispisuje slovno ocjenu, a ako korisnik nije unosio ocjenu
        //Program ispisuje pogrešku
        public static void Izvedi()
        {
            
            Console.Write("Unesi ocjenu ");
            int ocjena = int.Parse(Console.ReadLine());

            switch (ocjena)
            {
                case 1:
                    Console.WriteLine("Nedovoljan");
                    break;

                case 2:
                    Console.WriteLine("Dovoljan");
                    break;
                case 3:
                    Console.WriteLine("Dobar");
                    break;
                case 4:
                    Console.WriteLine("Vrlo dobar");
                    break;
                    case 5:
                    Console.WriteLine("Izvrstan");
                    break;
                default:
                    Console.WriteLine("Pogreška");
                    break;


            }









        }
    }
}
