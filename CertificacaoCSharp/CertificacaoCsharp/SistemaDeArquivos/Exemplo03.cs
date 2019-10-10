using System;
using System.IO;

namespace CertificacaoCsharp.SistemaDeArquivos
{
    internal class Exemplo03
    {
        private static void XMain(string[] args)
        {
            //TAREFA: Usar FileStream dá muito trabalho...
            //        Não podemos usar algo mais simples??

            using (StreamWriter gravadorFluxo = new StreamWriter("ArquivoSaida.txt"))
            {
                gravadorFluxo.Write("Olá, Alura! (gravado com StreamWriter)");
            }

            using (StreamReader leitorFluxo = new StreamReader("ArquivoSaida.txt"))
            {
                string textoLido = leitorFluxo.ReadToEnd();
                Console.WriteLine("Texto lido: {0}", textoLido);
                Console.ReadKey();
            }
        }
    }
}