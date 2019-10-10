﻿using System;
using System.IO;
using System.IO.Compression;

namespace CertificacaoCsharp.SistemaDeArquivos
{
    internal class Exemplo04
    {
        private static void XMain(string[] args)
        {
            //TAREFA: USAR ARQUIVO COMPACTADO Texto.zip NO LUGAR
            //DO ArquivoSaida.txt

            using (FileStream fluxoArquivo = new FileStream("Texto.zip", FileMode.OpenOrCreate, FileAccess.Write))
            {
                using (GZipStream compactador = new GZipStream(fluxoArquivo, CompressionMode.Compress))
                {
                    using (StreamWriter gravadorFluxo = new StreamWriter(compactador))
                    {
                        gravadorFluxo.Write("Olá, Alura! (gravado com StreamWriter)");
                    }
                }
            }

            using (FileStream fluxoArquivo = new FileStream("Texto.zip", FileMode.Open, FileAccess.Read))
            {
                using (GZipStream descompactador = new GZipStream(fluxoArquivo, CompressionMode.Decompress))
                {
                    using (StreamReader leitorFluxo = new StreamReader(descompactador))
                    {
                        string textoLido = leitorFluxo.ReadToEnd();
                        Console.WriteLine("Texto lido: {0}", textoLido);
                        Console.ReadKey();
                    }
                }
            }
        }
    }
}