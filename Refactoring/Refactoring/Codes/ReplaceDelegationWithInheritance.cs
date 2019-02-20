using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Refactoring.Codes
{
    class ReplaceDelegationWithInheritance
    {
        void ReplaceDelegationWithInheritanceMain()
        {
            var imovel =
                new Apartamento("Rua dos Bobos, No. 0", 100000, 200);
        }
    }

    class Imovel2
    {
        private readonly String endereco;
        private decimal valorImovel;

        public string Endereco => endereco;
        public decimal ValorImovel { get => valorImovel; set => valorImovel = value; }

        public Imovel2(string endereco, decimal valorImovel)
        {
            this.endereco = endereco;
            this.valorImovel = valorImovel;
        }
    }

    class Apartamento
    {
        private readonly Imovel2 imovel;
        private decimal valorCondominio;

        public string Endereco => imovel.Endereco;
        public decimal ValorImovel { get => imovel.ValorImovel; set => imovel.ValorImovel = value; }

        public Apartamento(string endereco, decimal valorImovel, decimal valorCondominio)
        {
            this.imovel = new Imovel2(endereco, valorImovel);
            this.valorCondominio = valorCondominio;
        }
    }
}
