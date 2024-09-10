/* using System;

class Program
{
    // Funkcija za generiranje spiralne ciklične matrice
    static int[,] GenerirajSpiralnuMatricu(int n)
    {
        int[,] matrica = new int[n, n];
        int broj = 1;

        // Definiranje granica
        int gornjaGranica = 0, donjaGranica = n - 1;
        int lijevaGranica = 0, desnaGranica = n - 1;

        while (gornjaGranica <= donjaGranica && lijevaGranica <= desnaGranica)
        {
            // 1. Popunjavanje donjeg reda s desna na lijevo
            for (int i = desnaGranica; i >= lijevaGranica; i--)
            {
                matrica[donjaGranica, i] = broj++;
            }
            donjaGranica--;

            // 2. Popunjavanje lijevog stupca odozdo prema gore
            for (int i = donjaGranica; i >= gornjaGranica; i--)
            {
                matrica[i, lijevaGranica] = broj++;
            }
            lijevaGranica++;

            // 3. Popunjavanje gornjeg reda s lijeva na desno
            if (gornjaGranica <= donjaGranica)
            {
                for (int i = lijevaGranica; i <= desnaGranica; i++)
                {
                    matrica[gornjaGranica, i] = broj++;
                }
                gornjaGranica++;
            }

            // 4. Popunjavanje desnog stupca odozgo prema dolje
            if (lijevaGranica <= desnaGranica)
            {
                for (int i = gornjaGranica; i <= donjaGranica; i++)
                {
                    matrica[i, desnaGranica] = broj++;
                }
                desnaGranica--;
            }
        }

        return matrica;
    }

    // Funkcija za ispis matrice
    static void IspisiMatricu(int[,] matrica)
    {
        int redovi = matrica.GetLength(0);
        int stupci = matrica.GetLength(1);

        for (int i = 0; i < redovi; i++)
        {
            for (int j = 0; j < stupci; j++)
            {
                Console.Write(matrica[i, j] + "\t");
            }
            Console.WriteLine();
        }
    }

    static void Main()
    {
        Console.Write("Unesite veličinu matrice: ");
        int n = int.Parse(Console.ReadLine());

        int[,] spiralnaMatrica = GenerirajSpiralnuMatricu(n);

        Console.WriteLine("Spiralna matrica:");
        IspisiMatricu(spiralnaMatrica);
    }
}
*/