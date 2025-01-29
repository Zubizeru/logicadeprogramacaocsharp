using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace logica07
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            string[] marcacarro = { "Volvo", "BMW", "Ford", "BYD" };

            // ======================= Usando Loop For Each ======================== 
            Console.WriteLine("Usando Loop For Each:");
            foreach (string carro in marcacarro)
            {
                Console.WriteLine(carro);
            }

            // ========================== Usando Loop For ========================== 
            Console.WriteLine("\nUsando Loop For:");
            for (int i = 0; i < marcacarro.Length; i++)
            {
                Console.Write($"{marcacarro[i]} \n");
            }

            // ============================ Usando .Join ===========================
            Console.WriteLine("\nUsando o método .Join:");
            string resultadojoin = $"{string.Join(", ", marcacarro, 0, marcacarro.Length - 1)} e {marcacarro[marcacarro.Length - 1]}";
            Console.WriteLine($"{resultadojoin}.");

            // ================ Mostrar apenas o valor de um índice ================
            Console.WriteLine("\nMostrar apenas o valor de um índice:");
            Console.WriteLine(marcacarro[2]);

            // ================== Exibindo o comprimento do array ==================
            Console.WriteLine("\nExibindo o comprimento do array:");
            Console.WriteLine(marcacarro.Length);

            // ===================== Ordenação de Strings A-Z ======================
            Console.WriteLine("\nOrdenação de Strings A-Z:");
            Array.Sort(marcacarro);
            foreach (string ordenado in marcacarro) 
            { 
                Console.WriteLine(ordenado); 
            }

            // ===================== Ordenação de Strings Z-A ======================
            Console.WriteLine("\nOrdenação de Strings Z-A:");
            Array.Reverse(marcacarro);
            foreach (string ordenado in marcacarro)
            {
                Console.WriteLine(ordenado);
            }

            // Análise de array de números
            int[] numeros = { 5, 1, 8, 9 };
            Console.WriteLine("\nAnálise de array de números:");
            Console.WriteLine($"Maior valor: { numeros.Max()}"); // Maior valor
            Console.WriteLine($"Menor valor: { numeros.Min()}"); // Menor valor
            Console.WriteLine($"Soma todos os números: { numeros.Sum()}"); // Soma todos os números

            Console.ReadLine();
        }
    }
}