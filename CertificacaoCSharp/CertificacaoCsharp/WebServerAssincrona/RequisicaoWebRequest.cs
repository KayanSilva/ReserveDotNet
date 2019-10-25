using System;
using System.IO;
using System.Net;

namespace CertificacaoCsharp.WebServerAssincrona
{
    class RequisicaoWebRequest
    {
        static void XMain(string[] args)
        {
            //TAREFAS:
            //1) conectar-se site da caelum (http://www.caelum.com.br)
            //2) obter o conteúdo da página do site
            //3) exibir o conteúdo da página

            WebRequest requisicao = WebRequest.Create("http://www.caelum.com.br");
            WebResponse resposta = requisicao.GetResponse();

            using (var leitorResposta = new StreamReader(resposta.GetResponseStream()))
            {
                var textoDoSite = leitorResposta.ReadToEnd();
                Console.WriteLine(textoDoSite);
                Console.ReadKey();
            }
        }
    }
}