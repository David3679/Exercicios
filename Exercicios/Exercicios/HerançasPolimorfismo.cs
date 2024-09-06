using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios.Exercicios
{
    internal class HerançasPolimorfismo
    {
        /*
        class Animal
        {
            public int Idade { get; set; }
            public string Nome { get; set; }

            public virtual void FazerBarulho()
            {
                Console.WriteLine("Todo animal faz um barulho!");
            }
        }

        class Cachorro : Animal
        {
            public string Raca { get; set; }

            public override void FazerBarulho()
            {
                Console.WriteLine("O cachorro late: Au au!");
            }

        }

        class Gato : Animal
        {
            public bool TemRabo { get; set; }

            public override void FazerBarulho()
            {
                Console.WriteLine("O gato mia: Miau!");
            }
        }

        static void Main(string[] args)
        {
            Animal[] animais = new Animal[]
            {
                new Cachorro{Nome = "Silver", Idade = 3, Raca = "Pitbull"},
                new Gato{Nome = "Frederico", Idade= 2, TemRabo = true}
            };

            foreach (var animal in animais)
            {
                Console.WriteLine($"{animal.Nome}, {animal.GetType().Name}, {animal.Idade} anos");
                animal.FazerBarulho();
                Console.WriteLine();
            }
        }
    }*/
    }
}
