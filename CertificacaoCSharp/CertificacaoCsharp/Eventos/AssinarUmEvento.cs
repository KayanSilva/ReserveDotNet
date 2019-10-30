using System;
using System.Collections.Generic;

namespace CertificacaoCsharp.Eventos
{
    internal class AssinarUmEvento
    {
        private static void XMain(string[] args)
        {
            try
            {
                Campainha2 campainha = new Campainha2();
                campainha.OnCampainhaTocou2 += CampainhaTocou3;
                campainha.OnCampainhaTocou2 += CampainhaTocou2;
                Console.WriteLine("A campainha será tocada.");
                campainha.Tocar("101");

                campainha.OnCampainhaTocou2 -= CampainhaTocou3;
                Console.WriteLine("A campainha será tocada.");
                campainha.Tocar("202");
            }
            catch (AggregateException e)
            {
                foreach (var exc in e.InnerExceptions)
                {
                    Console.WriteLine(exc.Message);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            Console.ReadKey();
        }

        private static void CampainhaTocou3(object sender, CampainhaEventArgs args)
        {
            Console.WriteLine("A campainha tocou no apartamento " + args.Apartamento + " .(1)");
            throw new Exception("Ocorreu um erro em CampainhaTocou1");
        }

        private static void CampainhaTocou2(object sender, CampainhaEventArgs args)
        {
            Console.WriteLine("A campainha tocou no apartamento " + args.Apartamento + " .(2)");
            throw new Exception("Ocorreu um erro em CampainhaTocou2");
        }
    }

    internal class Campainha2
    {
        public event EventHandler<CampainhaEventArgs> OnCampainhaTocou2;

        public void Tocar(string apartamento)
        {
            List<Exception> erros = new List<Exception>();
            foreach (var manipulador in OnCampainhaTocou2.GetInvocationList())
            {
                try
                {
                    manipulador.DynamicInvoke(this, new CampainhaEventArgs(apartamento));
                }
                catch (Exception e)
                {
                    erros.Add(e.InnerException);
                }
            }

            throw new AggregateException(erros);
        }
    }

    internal class CampainhaEventArgs : EventArgs
    {
        public CampainhaEventArgs(string apartamento) => Apartamento = apartamento;

        public string Apartamento { get; }
    }
}