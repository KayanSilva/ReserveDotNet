using ServiceReference1;
using System;
using System.Threading.Tasks;

namespace CertificacaoCsharp.ConsumindoServicos
{
    class ServicoWCF
    {
        static async Task Main(string[] args)
        {
            //TAREFA:
            //1. ADICIONAR UMA REFERÊNCIA A UM SERVIÇO
            //      WCF (WINDOWS COMMUNICATION FOUNDATION)
            //2. CONSUMIR O SERVIÇO E EXIBIR OS CURSOS DE NÚMERO 1 A 15

            var cliente = new MeuServicoClient();

            for (int i = 1; i <= 15; i++)
            {
                var nomeCurso = await cliente.GetValorAsync(i);
                Console.WriteLine(nomeCurso);
            }

            Console.ReadKey();
        }
    }
}