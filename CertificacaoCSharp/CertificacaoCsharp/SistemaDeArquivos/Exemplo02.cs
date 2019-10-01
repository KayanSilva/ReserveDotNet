﻿using System;
using System.IO;
using System.Text;

namespace CertificacaoCsharp.SistemaDeArquivos
{
    internal class Exemplo02
    {
        private static void XMain(string[] args)
        {
            // GRAVANDO UM ARQUIVO

            using (FileStream fluxoSaida
                = new FileStream("ArquivoSaida.txt", FileMode.Create, FileAccess.Write))
            {
                string mensagemSaida = "Olá, Alura!";

                byte[] array = Encoding.UTF8.GetBytes(mensagemSaida);
                int posicao = 0;
                int tamanho = mensagemSaida.Length;
                fluxoSaida.Write(array, posicao, tamanho);
            }

            using (FileStream fluxoEntrada
                = new FileStream("ArquivoSaida.txt",
                    FileMode.Open, FileAccess.Read))
            {
                byte[] bytesLidos = new byte[fluxoEntrada.Length];
                int posicao = 0;
                fluxoEntrada.Read(bytesLidos, posicao, (int)fluxoEntrada.Length);
                string texto = Encoding.UTF8.GetString(bytesLidos);
                Console.WriteLine("Mensagem Lida: " + texto);
            }

            Console.ReadKey();
        }
    }
}