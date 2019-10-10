using System;
using System.IO;

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

            DirectoryInfo diretorioInicial = new DirectoryInfo(@"..\..\..");
            ListarDiretorios(diretorioInicial);
        }

        private static void ListarDiretorios(DirectoryInfo diretorioInicial)
        {
            foreach (var diretorio in diretorioInicial.GetDirectories())
            {
                Console.WriteLine(diretorio.FullName);

                foreach (var arquivo in diretorio.GetFiles("*.cs"))
                {
                    Console.WriteLine(arquivo.FullName);
                }

                ListarDiretorios(diretorio);
            }
        }
    }
}