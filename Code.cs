using System;

namespace MineSweeper
{

    class Program
    {

        static Random rnd = new Random();

        static void Main(string[] args)
        {
            int m = 10, n = 10; // Rozmery minoveho pole
            int pocetMin = 10;
            int[,] miny = new int[m, n]; // Deklarace pole
            // 0 - nic, 1-8 cislo, 9 - mina, zaporna verze cisla (pro 0 je -10) = odkryte pole 

            // Rozmisteni min
            for (int k = 0; k < pocetMin; k++)
            {
                int i = rnd.Next(m);
                int j = rnd.Next(n);
                while (miny[i, j] == 9)
                {
                     (i, j) = (rnd.Next(m), rnd.Next(n));  
                }
                miny[i, j] = 9;

            }

        }

        static void VypisMinovehoPole(int[,] miny)
        {
            for (int i = 0; i < miny.GetLength(0); i++)
            {
                for (int j = 0; j < miny.GetLength(1); j++)
                {

                }
            }
        }
    }
}
