using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Refactoring.Codes
{
    class ReplaceInheritanceWithDelegation
    {

        void ReplaceInheritanceWithDelegationMain()
        {
            var imovel =
                new Imovel("Rua dos Bobos, No. 0", 100000,
                new Proprietario("Vinicius de Moraes", "123456789-00"));
        }
    }

    class Proprietario
    {
        public string Nome { get; }
        public string CPF { get; }
        internal IList<Imovel> Imoveis { get; } = new List<Imovel>();
        public int NumeroDeProcessos { get; set; }

        public Proprietario(string nome, string cpf)
        {
            Nome = nome;
            CPF = cpf;
        }
    }

    class Imovel
    {
        internal Proprietario Proprietario { get; set; }

        private readonly string endereco;
        private readonly decimal valor;

        public Imovel(string endereco, decimal valor, Proprietario proprietario)
        {
            Proprietario = proprietario;
            this.endereco = endereco;
            this.valor = valor;
        }
    }
}