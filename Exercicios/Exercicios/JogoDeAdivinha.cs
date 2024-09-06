using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios.Exercicios
{
    internal class JogoDeAdivinha
    {
        /*
        static void Main(string[] args)
        {
            Random random = new Random();
            int numeroSecreto = random.Next(1, 100);
            int tentativas;
            int numeroDeTentativas = 0;
            bool acertou = false;

            while (!acertou)
            {
                Console.Write("Digite o palpite para o número secreto: ");
                if (int.TryParse(Console.ReadLine(), out tentativas))
                {
                    numeroDeTentativas++;

                    if (tentativas < 0 && tentativas > 100)
                    {
                        Console.WriteLine("Número invalído, o palpite deve ser entre 1 á 100.");
                    }
                    else if (tentativas < numeroSecreto)
                    {
                        Console.WriteLine("O número secreto é maior.");
                    }
                    else if (tentativas > numeroSecreto)
                    {
                        Console.WriteLine("O número secreto é menor.");
                    }
                    else
                    {
                        acertou = true;
                        Console.WriteLine($"Parabéns, você acertou o número secreto que era {numeroSecreto} com {numeroDeTentativas} tentativas.");
                    }
                }
            }
        }*/
    }
}
