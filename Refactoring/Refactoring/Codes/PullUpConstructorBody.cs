using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Refactoring.Codes
{
    class PullUpConstructorBody
    {
        void PullUpConstructorBodyMain()
        {
            var cliente1 = new PessoaJuridica1("Alura Cursos Online S/A", "Rua XPTO", "123", "12345678/0001-22");
            var cliente2 = new PessoaFisica1("João Snow", "Rua das Flores", "987", "123456789-12");
            var clientes = new List<Cliente4> { cliente1, cliente2 };

            Console.WriteLine("Clientes");
            Console.WriteLine("========");
            foreach (var cliente in clientes)
            {
                Console.WriteLine($"{cliente.Nome}");
                Console.WriteLine($"{cliente.GetEndereco()}");
                Console.WriteLine("========");
            }
        }
    }

    abstract class Cliente4
    {
        protected string nome;
        public string Nome => nome;

        protected string logradouro;
        protected string numero;

        public Cliente4(string nome, string logradouro, string numero)
        {
            this.nome = nome;
            this.logradouro = logradouro;
            this.numero = numero;
        }

        public string GetEndereco()
        {
            return $"{logradouro} {numero}";
        }
    }

    class PessoaFisica1 : Cliente4
    {
        private readonly string cpf;
        public string Cpf => cpf;

        public PessoaFisica1(string nome, string logradouro, string numero, string cpf)
            : base(nome, logradouro, numero)
        {
            this.cpf = cpf;
        }
    }

    class PessoaJuridica1 : Cliente4
    {
        private readonly string cnpj;
        public string Cnpj => cnpj;

        public PessoaJuridica1(string nome, string logradouro, string numero, string cnpj)
            : base(nome, logradouro, numero)
        {
            this.cnpj = cnpj;
        }
    }
}
