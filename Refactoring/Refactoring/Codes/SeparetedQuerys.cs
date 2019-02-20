using System.Collections.Generic;
using Refactoring.Models;

namespace Refactoring.Codes
{
    public static class SeparetedQuerys
    {
        public static void SeparetedQueryMain()
        {
            IList<NotaFiscal> notasFiscais = new List<NotaFiscal>
            {
                new NotaFiscal(1, 5000),
                new NotaFiscal(2, 1000),
                new NotaFiscal(3, 2000),
                new NotaFiscal(4, 7000),
                new NotaFiscal(5, 2000)
            };

            var client = new Client();
            client.AddNf(notasFiscais);
            client.VerifyNotasFiscais();
        }
    }
}