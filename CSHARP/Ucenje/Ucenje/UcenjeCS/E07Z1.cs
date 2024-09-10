using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS
{
    internal class E07Z1
    {
        public static void Izvedi()
        {
            //Program od korisnika unosi cijeli broj (osigurava se uznos)
            // While petlju
            // Zbroj svih parnih brojeva od 1 do unesenog broja (Skupoa s njim)
            // UNos 10 ispis 30

            /*
                        int broj;
                        int suma = 0;

                        Console.Write("Unesi cijeli broj : ");
                        while (true)
                        {
                            try
                            {
                                broj = int.Parse(Console.ReadLine());
                                if (broj < 1 || broj > 20)
                                {
                                    Console.WriteLine("Broj mora biti između 2 i 19 ");
                                    continue;
                                }
                                break;
                            }
                            catch
                            {
                                Console.WriteLine("Niste unijeli broj!");
                            }

                        }


                        if (broj % 2 == 0)
                            {
                                suma+= broj;

                            }


                        Console.WriteLine("Zbroj svih parnih brojeva je :  " + suma);
            */



            // unos 10 brojeva, ispisuje zbroj svih 10 brojeva i ispisuje jednog ispod drugog

            int[] brojevi = new int[10];
            int suma = 0;

            for (int i = 0; i < brojevi.Length; i++)
            {

                Console.WriteLine("Unesi {0}. broj : ", i + 1);
                brojevi[i] = int.Parse(Console.ReadLine()); // treba osigurati unos broja
                suma += brojevi[i];

            }


            Console.WriteLine(brojevi);
            foreach (var b in brojevi)
            {
                Console.WriteLine(b);

            }
        }

    }
}

