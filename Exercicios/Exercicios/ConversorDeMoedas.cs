using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios.Exercicios
{
    internal class ConversorMoedas
    {
        /*
        private static Dictionary<string, double> taxasDeConversoes = new Dictionary<string, double>
        {
            {"BRL", 5.61},
            {"USD", 1},
            {"EUR", 0.93},
            {"JPY", 154.55}
        };

        static void Main(string[] args)
        {
            Console.WriteLine("Bem vindo ao conversor de moedas\n");

            double valor = LerValor();

            string moedaOrigem = LerMoeda("Origem");

            string moedaDestino = LerMoeda("Destino");

            double resultado = Conversao(valor, moedaOrigem, moedaDestino);

            ExibirConversao(valor, moedaOrigem, moedaDestino, resultado);

        }

        static double LerValor()
        {
            Console.Write("\nDigite o valor a ser convertido: ");
            if (!double.TryParse(Console.ReadLine(), out double valor) || valor <= 0)
            {
                Console.WriteLine("O valor inserido está negativo, tente novamente.");
                return 0;
            }
            return valor;
        }

        static string LerMoeda(string tipo)
        {
            Console.Write($"\nDigite o tipo de moeda para a {tipo} da conversão, temos (BRL), (USD), (EUR), (JPY): ");
            string moeda = Console.ReadLine().ToUpper();

            if (!taxasDeConversoes.ContainsKey(moeda))
            {
                Console.WriteLine("Não temos conversões para esse tipo, tente novamente.");
                return null;
            }
            return moeda;
        }

        static double Conversao(double valor, string moedaOrigem, string moedaDestino)
        {
            if (moedaOrigem == moedaDestino)
            {
                Console.WriteLine("Está conversão foi usada duas moeda destintas.");
                return valor;
            }

            double taxaDeOrigem = taxasDeConversoes[moedaOrigem];
            double taxaDeDestino = taxasDeConversoes[moedaDestino];

            double valorEmBase = valor / taxaDeOrigem;
            return valorEmBase * taxaDeDestino;
        }

        static void ExibirConversao(double valor, string moedaOrigem, string moedaDestino, double resultado)
        {
            Console.WriteLine($"\n{valor} {moedaOrigem} convertido em {moedaDestino} fica {resultado:F2}.");
        }
        */
    }
}
