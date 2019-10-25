using System;
using System.Net;

namespace CertificacaoCsharp.WebServerAssincrona
{
    class RequisicaoWebClient
    {
        static void XMain(string[] args)
        {
            //TAREFA:
            //Conectar-se site da caelum (http://www.caelum.com.br)
            //apenas para obter e exibir o conteúdo da página do site
            //mas de forma mais simples e rápida

            using (var webClient = new WebClient())
            {
                string textoDoSite = webClient.DownloadString("http://www.caelum.com.br");
                Console.WriteLine(textoDoSite);
                Console.ReadKey();
            }
        }
    }
}