using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS
{
    internal class EO5O1
    {

        public static void Izvedi()
        {

            // Za unesenu riječ provjerite da li je palindrom?
            // Palindrom je riječ koja se jednako čita s obje strane
            // anavolimilovana, 02022020, ananabraparbanana, evolove, evoove


            string ime = "anna";
            bool palindrom = true;

            for (int i = 0; i < ime.Length / 2; i++)
            {
                if (ime[i] == ime[ime.Length - 1 - i])
                {
                   

                }
                else
                {
                    
                    palindrom = false;
                    break;
                }


            }
            /*
                        if (palindrom) 

                        {
                            Console.WriteLine("Rijec je palindrom");
                        }
                        else
                        {
                            Console.WriteLine("Nije palindrom");
                        }
              */

            Console.WriteLine("Rijec {0} palindrom", palindrom? "Je" : "Nije");


        }
    }
}

