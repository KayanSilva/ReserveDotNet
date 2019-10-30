using System;

namespace CertificacaoCsharp.Eventos
{
    internal class Delegados
    {
        private delegate int Operacao(int a, int b);

        private static void XMain(string[] args)
        {
            int a = 3;
            int b = 2;

            Operacao operacao = Somar;

            Console.WriteLine(operacao(a, b));

            operacao = Subtrair;

            Console.WriteLine(operacao(a, b));

            Console.ReadKey();
        }

        private static int Somar(int a, int b)
        {
            Console.WriteLine($"A operação Somar foi chamada com a = {a} e b = {b}");
            return a + b;
        }

        private static int Subtrair(int a, int b)
        {
            Console.WriteLine($"A operação Subtrair foi chamada com a = {a} e b = {b}");
            return a - b;
        }
    }
}