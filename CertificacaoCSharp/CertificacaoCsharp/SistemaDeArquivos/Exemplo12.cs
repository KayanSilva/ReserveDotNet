using System;
using System.IO;
using System.Linq;

namespace CertificacaoCsharp.SistemaDeArquivos
{
    internal class Exemplo12
    {
        private static void XMain(string[] args)
        {
            //TAREFAS:
            //Obter o diretório de início do projeto
            //Listar todos os diretórios do projeto
            //Listar todos os arquivos csharp (.cs) do projeto

            var diretorioInicial = new DirectoryInfo(@"..\..\..");
            ListarDiretorios(diretorioInicial);
        }

        private static void ListarDiretorios(DirectoryInfo diretorioInicial)
        {
            diretorioInicial.GetDirectories().ToList().ForEach(diretorio =>
            {
                Console.WriteLine(diretorio.FullName);
                diretorio.GetFiles(".cs").ToList().ForEach(arquivo => Console.WriteLine(arquivo.FullName));
                ListarDiretorios(diretorio);
            });
        }
    }
}