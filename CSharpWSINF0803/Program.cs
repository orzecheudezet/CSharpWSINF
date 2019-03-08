using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpWSINF0803
{
    class Program
    {
        static void Main(string[] args)
        {
            //Zmienne
            int liczba = 0;
            //double - Nie jest to dkoładny sposób reprezentacji liczby
            double d = 0.0;
            float f = 3.14f;
            short s = 32000; // typ 2 bajtowy ze znakiem
            byte b = 254; // 
            long duzy = 1000000000000000000;
            char ch = '\'';
            bool log = true;                                                                                                                                      
            decimal m = 0.01m;
            string tekst = "Ala ma kota";
            byte b2 = b;
            b = 200;
            Console.WriteLine(b);
            Console.WriteLine(b2);

            String sciezka = "c:\\Users\\plik";
            String sciezka2 = @"c:\Users\plik";

            //Tablice
            int[] tab = new int[3];
            tab[0] = 5;
            Console.WriteLine(tab[1]);
            int[] pierwsze = new int[] {2, 3, 5, 7, 11};
            int[] krotka = {2, 3, 5, 7, 11};

            int[][] z = new int[3][];
            z[0] = new int[3];
            z[1] = new int[0];
            z[2] = new int[] { 2, 3, 5, 7 };

            for (int i = 0; i < z.Length; i++)
            {
                for (int j = 0; j < z[i].Length; j++)
                {
                    Console.WriteLine(z[i][j]);
                }
                Console.WriteLine();

            }

            foreach (int[] wewnetrzna in z)
            {
                foreach (int element in wewnetrzna)
                {
                    Console.WriteLine(element);
                }
                Console.WriteLine();
            }

            int[,] matrix = new int[3, 5];
            matrix[0, 0] = 1;

            Console.ReadKey();



        }
    }
}
