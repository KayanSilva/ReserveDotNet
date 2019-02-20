using System;
using Refactoring.Interfaces;
using Refactoring.Services;

namespace Refactoring.Codes
{
    public static class ExtractInterface
    {
        public static void ExtractIntMain()
        {
            IFormatter formatadorCNPJ = new CnpjFormatter();
            const string codigoCNPJ = "12345678000099";
            ImprimirCodigoFormatado(formatadorCNPJ, codigoCNPJ);

            IFormatter formatadorCPF = new CpfFormatter();
            const string codigoCPF = "12345678001";
            ImprimirCodigoFormatado(formatadorCPF, codigoCPF);

        }

        private static void ImprimirCodigoFormatado(IFormatter formatador, string codigo)
        {
            Console.WriteLine($"Código formatado: {formatador.Format(codigo)}");
        }
    }
}