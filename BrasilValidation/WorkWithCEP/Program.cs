using System.Diagnostics;
using System.Net.Http;
using Caelum.Stella.CSharp.Http;

namespace WorkWithCEP
{
    class Program
    {
        static void Main(string[] args)
        {
            const string cep = "01001000";
            var result = GetEndereco(cep);
            Debug.WriteLine(result);

            var viaCEP = new ViaCEP();
            var enderecoJson = viaCEP.GetEnderecoJson(cep);
            Debug.WriteLine(enderecoJson);

            var enderecoXml = viaCEP.GetEnderecoXml(cep);
            Debug.WriteLine(enderecoXml);

            var task = viaCEP.GetEnderecoJsonAsync(cep);
            Debug.WriteLine(task.Result);

            var endereco = viaCEP.GetEndereco(cep);
            Debug.WriteLine($"Logradouro: {endereco.Logradouro}, Bairro: {endereco.Bairro}");
        }

        private static string GetEndereco(string cep)
        {
            var url = $"https://viacep.com.br/ws/{cep}/json/";
            using (var httpClient = new HttpClient())
            {
                var result = httpClient.GetStringAsync(url).Result;
                return result;
            }
        }
    }
}