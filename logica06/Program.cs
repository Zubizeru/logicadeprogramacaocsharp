using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace logica06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // ================ Declarando dois vetores ================
            //int[] numeros = { 1, 2, 3, 4, 5 };
            //string[] nomes = { "Ana", "João", "Maria", "Carlos" };

            // Exibindo os elementos do vetor de números com loop for
            //Console.WriteLine("Vetor de números (usando for):");
            //for (int i = 0; i < numeros.Length; i++)
            //{
            //    Console.WriteLine(numeros[i]);
            //}

            // Exibindo os elementos do vetor de nomes com loop foreach
            //Console.WriteLine("\nVetor de nomes (usando foreach):");
            //foreach (var nome in nomes)
            //{
            //    Console.WriteLine(nome);
            //}

            // ============== Vetor de números para ordenar ==============
            int[] numeros = { 5, 3, 8, 4, 2 };

            

            Console.WriteLine("Vetor Original:");
            ExibirVetor(numeros);

            // Bubble Sort
            Console.WriteLine("\nVetor ordenado com Bubble Sort:");

            BubbleSort(numeros);

            /* Organizar mais fácilmente
            
            Array.Sort(numeros);
            foreach (int i in numeros)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();

            */

            ExibirVetor(numeros);

            Console.ReadLine();
        }

        // ================== Função para exibir o vetor ================= 
        static void ExibirVetor(int[] vetor)
        {
            foreach (var numero in vetor)
            {
                Console.Write(numero + " ");
            }
            Console.WriteLine();
        }

        // ============= Função para exibir o vetor ordenado ============= 
        static void BubbleSort(int[] vetor)
        {
            int n = vetor.Length; // Comprimento do vetor
            for (int i = 0; i < n - 1; i++) // Comparar posição com a proxima posição
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (vetor[j] > vetor[j + 1])
                    {
                        // Troca os elementos
                        int temp = vetor[j];
                        vetor[j] = vetor[j + 1];
                        vetor[j + 1] = temp;
                    }
                }
            }
        }


    }  
        
}
