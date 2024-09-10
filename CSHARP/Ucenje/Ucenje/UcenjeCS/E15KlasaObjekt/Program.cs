using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UcenjeCS.E15KlasaObjekt.Edunova;

namespace UcenjeCS.E15KlasaObjekt
{
    internal class Program
    {

        public static void Izvedi()
        {

            Console.WriteLine("Hello OOP");

            //Objekt je instanca (pojavnost) klase

            //Osoba je ime klase
            //osoba je ime objekta (instance / pojavnosti) - varijabla

            Osoba osoba; // deklariran, bez instance

            osoba = new Osoba();  // Konstruiranje objekta- RAĐA SE, kreira se - zauzima memoriju

            osoba.Ime = "Pero"; //Objekt zivi i posjeduje vrijednosti - postavljamo ih

            Console.WriteLine(osoba.Ime); //objekt zivi i posjeduje vrijednosti koji se konzumiraju

            osoba.Prezime = "Perić";

            Console.WriteLine(osoba.ImePrezime()); // metoda ImePrezime nije statična jer nju zovem na objekt

            // a na kraju objekt (osoba) umire - UNIŠTAVA GA/ČISTI iz memorije
            // MI NE UNIŠTAVAMO objekt, to radi Garbagge collector



            // Drugi načini kreiranja objekta

            Osoba ravnatelj = new Osoba
            {
                Sifra = 1,
                Ime = "Marko",
                Prezime = "Kas"
            };

            var direktor = new Osoba { Ime = "Edo" }; // dobra praksa

            Osoba profesor = new() { Prezime = "Reh" };

             Console.WriteLine(profesor.Ime?.ToUpper());


            var o = new Osoba()
            {
                Ime = "Marija",
                Mjesto = new() { Naziv = "Osijek", PostanskiBroj = "31000" }
               
            };

            Console.WriteLine(o.Mjesto?.Naziv?.ToUpper());


            // Dugi način

            Zupanija obz = new Zupanija();
            obz.Naziv = "Osječko-Baranjska zupanija";

            Mjesto os = new Mjesto();
            os.Naziv = "Osijek";

            os.Zupanija = obz;

            Osoba ja= new Osoba();
            ja.Ime = "Tomislav";
            ja.Mjesto = os;

            //Ispišite u konzoli iz objekta ja vrijednost Osjecko baranjska zupanija

            Console.WriteLine(ja.Mjesto?.Zupanija?.Naziv);

            
            // objekti iz edunova klasa

            var smjer= new Smjer() { Sifra=E11Metode.UcitajCijeliBroj("Unesi sifru",1,10000), Naziv="Web" }; 

            var grupa = new Grupa() { Naziv="WP5", Smjer=smjer };

            //zadatak : ispiši šifru smjera na grupi WP5
            Console.WriteLine(grupa.Smjer.Sifra);
        }
    }
}
