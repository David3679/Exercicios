using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios.Exercicios
{
    internal class API_Externa
    {
        /*
        public class CepResponse
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
            string cep = "01001000"; // CEP de exemplo
            string url = $"https://viacep.com.br/ws/{cep}/json/";

            // Verificação da URL
            if (Uri.IsWellFormedUriString(url, UriKind.Absolute))
            {
                using (HttpClient client = new HttpClient())
                {
                    try
                    {
                        HttpResponseMessage response = await client.GetAsync(url);

                        if (response.IsSuccessStatusCode)
                        {
                            string responseData = await response.Content.ReadAsStringAsync();
                            CepResponse cepData = JsonConvert.DeserializeObject<CepResponse>(responseData);

                            Console.WriteLine($"CEP: {cepData.Cep}");
                            Console.WriteLine($"Logradouro: {cepData.Logradouro}");
                            Console.WriteLine($"Bairro: {cepData.Bairro}");
                            Console.WriteLine($"Cidade: {cepData.Localidade}");
                            Console.WriteLine($"Estado: {cepData.Uf}");
                        }
                        else
                        {
                            Console.WriteLine($"Erro: {response.StatusCode}");
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Exceção: {ex.Message}");
                    }
                }
            }
            else
            {
                Console.WriteLine("A URL fornecida não é uma URI absoluta válida.");
            }
        }*/
    }
}

