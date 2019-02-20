using System;
using System.Collections.Generic;

namespace Refactoring.Models
{
    class Client
    {
        public IList<Location> Location { get; set; }
        public double TotalValue { get; set; }
        public double LoyaltyPoints { get; set; }
        public string Name { get; set; }

        private const int MinimumValueNFPremium = 10000;
        private readonly List<NotaFiscal> NotasFiscais;

        internal void AddNf(IList<NotaFiscal> notasFiscais)
        {
            NotasFiscais.AddRange(notasFiscais);
        }

        public void VerifyNotasFiscais()
        {
            var nf = GetNFPremium(NotasFiscais);
            if (nf != null)
            {
                EnviarEmailParabens(nf);
                CriarCartaoPremium(nf);
            }
        }

        public static NotaFiscal GetNFPremium(IList<NotaFiscal> notasFiscais)
        {
            foreach (var nf in notasFiscais)
            {
                if (nf.Value > MinimumValueNFPremium)
                {
                    return nf;
                }
            }
            return null;
        }

        private static void CriarCartaoPremium(NotaFiscal nf)
        {
            //código para criar cartão de cliente premium
            Console.WriteLine(nf.ToString());
        }

        private static void EnviarEmailParabens(NotaFiscal nf)
        {
            var Mensagem =
                "Prezado Cliente, " +
                $"Parabéns! Você se tornou Cliente Premium através da NF: {nf}" +
                "e receberá em breve um cartão exclusivo da nossa loja! " +
                "" +
                "Atenciosamente, " +
                "" +
                "A Sua Loja" +
                "http://asualojamaislegal.com.br";

            //aqui vai o código para enviar o email

            Console.WriteLine(Mensagem);
        }
    }
}