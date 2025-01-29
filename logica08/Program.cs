using System;

namespace logica08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Declaração e inicialização de uma matriz 3x3
            int[,] matriz2D = new int[,]
            {
                { 1, 2, 3 },
                { 4, 5, 6 },
                { 7, 8, 9 }
            };

            // Com laço For each
            Console.WriteLine("Com laço For each:");
            foreach (var valor in matriz2D)
            {
                Console.Write($"{valor} ");
            }
            Console.WriteLine();

            // Com laço for
            Console.WriteLine("\nCom laço For:");
            for (int i = 0; i < matriz2D.GetLength(0); i++)
            {
                for (int j = 0; j < matriz2D.GetLength(1); j++)
                {
                    Console.Write($"{matriz2D[i, j]} ");
                }
            }
            Console.WriteLine();

            // Declaração e inicialização de uma matriz 1D
            int[] matriz1D = new int[5] { 10, 20, 30, 40, 50 };

            // Exibindo os valores da matriz 1D
            Console.WriteLine("\nExibindo os valores da matriz 1D:");
            for (int i = 0; i < matriz1D.Length; i++)
            {
                Console.Write($"{matriz1D[i]} ");
            }

            Console.ReadLine();
        }
    }
}
