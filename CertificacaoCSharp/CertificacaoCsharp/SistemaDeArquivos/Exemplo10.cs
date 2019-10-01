﻿using System;
using System.IO;

namespace CertificacaoCsharp.SistemaDeArquivos
{
    internal class Exemplo10
    {
        private static void XMain(string[] args)
        {
            //TAREFA:
            //Criar um novo diretório
            //Verificar se ele foi criado
            //Exibir os atributos do diretório
            //Exibir último acesso
            //Apagar o diretório que foi criado

            DirectoryInfo localDir = new DirectoryInfo("NovoDiretorio");
            localDir.Create();
            if (localDir.Exists)
            {
                Console.WriteLine("Diretório criado com sucesso");
            }
            Console.WriteLine("Atributos: {0}", localDir.Attributes);
            Console.WriteLine("Último acesso: {0}", localDir.LastAccessTime);
            localDir.Delete();
            Console.WriteLine("Diretório removido com sucesso");
        }
    }
}