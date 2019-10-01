using System;
using System.IO;
using System.Linq;

namespace CertificacaoCsharp.SistemaDeArquivos
{
    public class Exemplo00
    {
        private static void XMain(string[] args)
        {
            //TAREFAS:
            //1. ABRIR O ARQUIVO Diretores.txt
            //2. LER 10 BYTES DO ARQUIVO
            //3. IMPRIMIR ESSES BYTES NO CONSOLE

            using (var fluxoDeArquivo = new FileStream("Diretores.txt", FileMode.Open, FileAccess.Read))
            {
                var array = new byte[10];
                var posicao = 0;
                var tamanho = 10;

                //PRIMEIRA LEITURA
                fluxoDeArquivo.Read(array, posicao, tamanho);

                array.ToList().ForEach(caractere => Console.Write((char)caractere));

                //SALTO RELATIVO: RELATIVO À POSIÇÃO ATUAL
                //SALTO ABSOLUTO: RELATIVO À POSIÇÃO INICIAL DO ARQUIVO

                fluxoDeArquivo.Seek(5, SeekOrigin.Begin);

                fluxoDeArquivo.Position = 5;

                //SEGUNDA LEITURA
                fluxoDeArquivo.Read(array, posicao, tamanho);

                array.ToList().ForEach(caractere => Console.Write((char)caractere));

                Console.ReadKey();
            }
        }
    }
}