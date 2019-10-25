using System;
using System.Net;
using System.Threading.Tasks;

namespace CertificacaoCsharp.WebServerAssincrona
{
    class RequisicaoWebClientAsync
    {
        static async Task XMain(string[] args)
        {
            //TAREFA:
            //Conectar-se site da caelum (http://www.caelum.com.br)
            //apenas para obter e exibir o conteúdo da página do site
            //de forma ASSÍNCRONA

            string textoDoSite = await LerTextoDoSite();
            Console.WriteLine(textoDoSite);
            Console.ReadKey();
        }

        private static async Task<string> LerTextoDoSite()
        {
            using (var webClient = new WebClient())
            {
                return await webClient.DownloadStringTaskAsync("http://www.caelum.com.br");
            }
        }
    }
}