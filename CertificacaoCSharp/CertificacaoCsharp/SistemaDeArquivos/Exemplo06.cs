using System;
using System.IO;

namespace CertificacaoCsharp.SistemaDeArquivos
{
    internal class Exemplo06
    {
        private static void XMain(string[] args)
        {
            try
            {
                string conteudo = File.ReadAllText("Arquivo.txt");
                Console.WriteLine("O conteúdo é: {0}", conteudo);
            }
            catch (FileNotFoundException e)
            {
                Console.WriteLine("O arquivo não foi encontrado.");
                Console.WriteLine(e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            Console.ReadKey();
        }
    }
}