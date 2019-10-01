using System;
using System.IO;

namespace CertificacaoCsharp.SistemaDeArquivos
{
    internal class Exemplo09
    {
        private const string NomeDiretorio = "NovoDiretorio";

        private static void XMain(string[] args)
        {
            //TAREFA:
            //Criar um novo diretório
            //Verificar se ele foi criado
            //Apagar o diretório que foi criado

            Directory.CreateDirectory(NomeDiretorio);
            if (Directory.Exists(NomeDiretorio))
            {
                Console.WriteLine("O diretório foi criado com sucesso");
            }
            Directory.Delete(NomeDiretorio);
            Console.WriteLine("O diretório foi removido com sucesso");
        }
    }
}