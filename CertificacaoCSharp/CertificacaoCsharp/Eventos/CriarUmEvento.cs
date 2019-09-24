using System;

namespace CertificacaoCsharp.Eventos
{
    class CriarUmEvento
    {
        static void Main(string[] args)
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

        static void CampainhaTocou1()
        {
            Console.WriteLine("A campainha tocou.(1)");
        }
        static void CampainhaTocou2()
        {
            Console.WriteLine("A campainha tocou.(2)");
        }
    }

    class Campainha1
    {
        public Action OnCampainhaTocou1 { get; set; }

        public void Tocar()
        {
            OnCampainhaTocou1?.Invoke();
        }
    }
}