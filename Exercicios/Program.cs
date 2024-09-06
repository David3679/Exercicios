using Exercicios.Exercicios;
using System;
using System.Collections.Immutable;
using System.ComponentModel;
using System.Diagnostics;
using System.IO.IsolatedStorage;
using System.Net.WebSockets;
using System.Runtime.Serialization;
using System.Security.Cryptography;
using System.Text.Json.Serialization;
using System.Xml;
using System.Net.Http;
using Newtonsoft.Json;


namespace Exercicios
{

    class Program
    {
        /*
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um número e séra impresso todos os números até chegar no de escolha\n");
            Console.WriteLine("Qual número deseja: ");
            if(int.TryParse(Console.ReadLine(), out int escolha) && escolha <= 0)
            {
                Console.WriteLine("O número não pode ser negativo.");
            }
            else
            {
                for(int i = 0; i <= escolha; i++)
                {
                    Console.WriteLine(i);
                }
            }
        }*/


        /*
        static void Main(string[] args)
        {
            for(int i = 0; i <= 100; i++)
            {
                if(i % 15 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                }
                else if(i % 5 == 0)
                {
                    Console.WriteLine("Fizz");
                }
                else if(i % 3 == 0)
                {
                    Console.WriteLine("Buzz");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
        }*/

        /*
        static void Main(string[] args)
        {
            int soma = 0;

            for(int i = 1; i <= 100; i++)
            {
                soma += i;
            }

            Console.WriteLine($"A soma dos números de um 1 a 100 é {soma}.");
        }*/

        /*
        static void Main(string[] args)
        {
            List<string> nomes = new List<string>();

            for(int i = 0; i < 5; i++)
            {
                Console.Write($"\nDigite um nome na posição {i}: ");
                string nomesDigitado = Console.ReadLine();

                if(string.IsNullOrEmpty(nomesDigitado))
                {
                    Console.WriteLine("O campo não pode ser nulo, tente novamente.");
                }
                else
                {
                    nomes.Add(nomesDigitado);
                }
            }

            nomes.Sort();

            foreach (var nome in nomes)
            {
                Console.WriteLine(nome);
            }
        }*/

        /*
        static List<Produto> produtos = new List<Produto>();

        public class Produto()
        {
            public Guid Id { get; set; }
            public string Nome { get; set; }
            public decimal Valor { get; set; }
        }

        static void Main(string[] args)
        {

            string exit = "";
            

            while(exit != "exit")
            {
                Console.WriteLine("Escolha uma das opções a baixo.\n");
                Console.WriteLine("1 - Adicionar produto");
                Console.WriteLine("2 - Excluir produto");
                Console.WriteLine("3 - Ver todos os produtos");

                int opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1: AdicionarProduto();
                        break;
                    case 2: ExcluirProduto();
                        break;
                    case 3: ListarProdutos();
                        break;
                }
            }
        }

        static void AdicionarProduto()
        {
            Console.WriteLine("Adicione um produto");

            Console.Write("\nNome do produto: ");
            string nomeProduto = Console.ReadLine();

            Console.Write("\nPreço do produto: ");
            decimal valorProduto = decimal.Parse(Console.ReadLine());

            if(nomeProduto != null && valorProduto != null)
            {
                Produto produto = new Produto { Id = Guid.NewGuid(), Nome = nomeProduto, Valor = valorProduto};
                produtos.Add(produto);
                Console.WriteLine("Produto adicionado com sucesso!");
            }
            else
            {
                Console.WriteLine("Nome ou valor nulos, tente novamente.");
            }
        }

        static void ExcluirProduto()
        {
            Console.WriteLine("Excluir um produto");
            Console.Write("\nDigite o ID do produto para ser removido: ");
            string idProduto = Console.ReadLine();

            Produto idRemove = produtos.Find(p => p.Id.ToString() == idProduto);

            if(idRemove != null)
            {
                produtos.Remove(idRemove);
                Console.WriteLine("Produto removido com sucesso!");
            }
            else
            {
                Console.WriteLine("Este ID não exite, tente novamente!");
            }        
        }

        static void ListarProdutos()
        {
            foreach(var produto in produtos)
            {
                Console.WriteLine($"ID do produto: {produto.Id} - Nome do produto: {produto.Nome} - Valor do produto: {produto.Valor}");
            }
        }*/

        
        public class CepInfo
        {
            public string Cep { get; set; }
            public string Logradouro { get; set; }
            public string Complemento { get; set; }
            public string Bairro { get; set; }
            public string Localidade { get; set; }
            public string Uf { get; set; }
            public string Ibge { get; set; }
            public string Gia { get; set; }
            public string Ddd { get; set; }
            public string Siafi { get; set; }
        }

        static async Task Main(string[] args)
        {
            string cep = "03828090";
            string url = $"http://viacep.com.br/ws/{cep}/json/";

            using (HttpClient client = new HttpClient())
            {
                try
                {
                    HttpResponseMessage response = await client.GetAsync(url);

                    if (response.IsSuccessStatusCode)
                    {
                        string responseData = await response.Content.ReadAsStringAsync();

                        CepInfo cepData = JsonConvert.DeserializeObject<CepInfo>(responseData);

                        Console.WriteLine($"CEP: {cepData.Cep}");
                        Console.WriteLine($"Logradouro: {cepData.Logradouro}");
                        Console.WriteLine($"Bairro: {cepData.Bairro}");
                        Console.WriteLine($"Cidade: {cepData.Localidade}");
                        Console.WriteLine($"Estado: {cepData.Uf}");

                    }
                    else
                    {
                        Console.WriteLine("O CEP é invalído");
                    }
                }catch(Exception ex)
                {
                    Console.WriteLine($"Erro: {ex}");
                }
            }
        }
    }
}