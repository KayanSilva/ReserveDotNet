using System;
using System.IO;
using System.Text;

namespace CertificacaoCsharp.SistemaDeArquivos
{
    internal class Exemplo01
    {
        private static void XMain(string[] args)
        {
            // GRAVANDO UM ARQUIVO
            var posicao = 0;

            using (var fluxoSaida = new FileStream("ArquivoSaida.txt", FileMode.Create, FileAccess.Write))
            {
                var mensagemSaida = "Olá, Alura!";

                var array = Encoding.UTF8.GetBytes(mensagemSaida);
                var tamanho = mensagemSaida.Length;
                fluxoSaida.Write(array, posicao, tamanho);
            }

            using (var fluxoEntrada = new FileStream("ArquivoSaida.txt", FileMode.Open, FileAccess.Read))
            {
                var bytesLidos = new byte[fluxoEntrada.Length];

                fluxoEntrada.Read(bytesLidos, posicao, (int)fluxoEntrada.Length);
                var texto = Encoding.UTF8.GetString(bytesLidos);

                Console.WriteLine("Mensagem Lida: " + texto);

                Console.ReadKey();
            }
        }
    }
}