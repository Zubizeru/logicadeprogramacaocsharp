using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace logica05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // ======================== Loop Até X =============================
             
           for (int i = 0; i <= 10; i++)
           {
               Console.WriteLine(i);
           };

           // ======================= Loop Infinito ============================

           /*
          
           for (; ; )
           {
               Console.WriteLine("Este é um loop infinito!");
           }

           */

            // ===================== While - enquanto ==========================

            int contador = 1;

            while (contador <= 5)
            {
                Console.WriteLine(contador);
                contador++; // Incrementa o contador
            };

            // =================== Do While - Faça enquanto ====================

            int novocontador = 2;

            do
            {
                Console.WriteLine(novocontador);
                novocontador++; // Incrementa o contador
            } while (novocontador <= 5);

            // ================== For Each - Array de Strings ==================

            List<string> nomes = new List<string> { "Ana", "Carlos", "João", "Maria" };

            foreach (string nome in nomes) // For Each para percorrer o array
            {
                Console.WriteLine(nome); // Imprime cada nome
            }

            // =================== Array de Números Inteiros ===================

            int[] numeros = { 1, 2, 3, 4, 5 };

            foreach (int numero in numeros) // For Each para percorrer o array
            {
                Console.WriteLine(numero); // Imprime cada número
            }

            Console.ReadLine();
        }       
    }
}
