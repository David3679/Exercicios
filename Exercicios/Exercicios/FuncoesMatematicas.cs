using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios.Exercicios
{
    internal class FuncoesMath
    {
        // Fatorial


        /*
        public static long Fatorial(int n)
        {
            if (n < 0)
                throw new ArgumentException("O número deve ser não negativo.");
            
                long resultado = 1;

                for(int i = 1; i <= n; i++)
                {
                    resultado *= i;
                }
                return resultado;         
        }

        static void Main(string[] args)
        {
            int numero = 5;

            Console.WriteLine($"O fatorial de {numero} é {Fatorial(numero)}");
        }*/


        // Potência


        /*
        public static double Potencia(double baseNum, int expoente)
        {
            if (expoente < 0)
                throw new ArgumentException("O expoente não pode ser negativo.");

            double resultado = 1;
            
            for(int i = 0; i < expoente; i++)
            {
                resultado *= baseNum;
            }
            return resultado;
        }

        static void Main(string[] args)
        {
            double baseNum = 2;
            int expoente = 3;

            Console.WriteLine($"{baseNum} elevado a {expoente} é {Potencia(baseNum, expoente)}");
        }*/


        //Número Primo


        /*
        public static bool NumPrimo(int numero)
        {
            if(numero <= 1)
            {
                return false;
            }

            if(numero == 2)
            {
                return true;
            }

            if(numero % 2 == 0)
            {
                return false;
            }

            for(int i = 3; i <= Math.Sqrt(numero); i += 2)
            {
                if(numero % i == 0)
                 return false;
                
            }
            return true;
        }

        static void Main(string[] args)
        {
            int numPrimo = 29;

            Console.WriteLine($"{numPrimo} é primo? {NumPrimo(numPrimo)}");
        }*/
    }
}
