using System;

namespace CertificacaoCsharp.Eventos
{
    internal class CriarUmEvento
    {
        private static void XMain(string[] args)
        {
            Campainha1 campainha = new Campainha1();
            campainha.OnCampainhaTocou1 += CampainhaTocou1;
            campainha.OnCampainhaTocou1 += CampainhaTocou2;
            Console.WriteLine("A campainha será tocada.");
            campainha.Tocar();

            campainha.OnCampainhaTocou1 -= CampainhaTocou1;
            Console.WriteLine("A campainha será tocada.");
            campainha.Tocar();

            Console.ReadKey();
        }

        private static void CampainhaTocou1()
        {
            Console.WriteLine("A campainha tocou.(1)");
        }

        private static void CampainhaTocou2()
        {
            Console.WriteLine("A campainha tocou.(2)");
        }
    }

    internal class Campainha1
    {
        public Action OnCampainhaTocou1 { get; set; }

        public void Tocar()
        {
            OnCampainhaTocou1?.Invoke();
        }
    }
}