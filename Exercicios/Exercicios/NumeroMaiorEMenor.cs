using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios.Exercicios
{
    internal class MaiorEMenor
    { 
        /*
        static void Main(string[] args)
        {
            int[] numeros = new int[10];

            Console.WriteLine("Contador de Números");

            for (int i = 0; i < numeros.Length; i++)
            {
                Console.Write($"\nDigite o {i + 1} número: ");

                while (!int.TryParse(Console.ReadLine(), out numeros[i]))
                {
                    Console.WriteLine("Digite um número que não seja negativo.");
                    Console.Write($"\nDigite o {i + 1} número novamente: ");
                }
            }

            int maiorNumero = numeros[0];
            int menorNumero = numeros[0];

            for (int i = 0; i < numeros.Length; i++)
            {
                if (numeros[i] > maiorNumero)
                {
                    maiorNumero = numeros[i];
                }
                if (numeros[i] < menorNumero)
                {
                    menorNumero = numeros[i];
                }
            }

            Console.WriteLine($"O maior número do array é {maiorNumero}");
            Console.WriteLine($"O menor número do array é {menorNumero}");
        }*/
    }
}
