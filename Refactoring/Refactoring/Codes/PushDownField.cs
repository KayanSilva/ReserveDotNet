using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Refactoring.Codes
{
    class PushDownField
    {
        void PushDownFieldMain()
        {
            Funcionario4 engenheiro = Funcionario4.CriarFuncionario(Funcionario4.TipoFuncionario4.Engenheiro, "José da Silva", 1000);
            Funcionario4 vendedor = Funcionario4.CriarFuncionario(Funcionario4.TipoFuncionario4.Vendedor, "Maria Bonita", 2000);
            Funcionario4 gerente = Funcionario4.CriarFuncionario(Funcionario4.TipoFuncionario4.Gerente, "João das Neves", 3000);

            var valorFolhaDePagamento =
                engenheiro.Salario
                + vendedor.Salario
                + gerente.Salario;
        }
    }

    class Funcionario4
    {
        public enum TipoFuncionario4
        {
            Engenheiro = 0,
            Vendedor = 1,
            Gerente = 2
        }

        protected TipoFuncionario4 tipo;
        public TipoFuncionario4 Tipo { get; }

        protected string nome;
        public string Nome => nome;

        protected decimal salario;
        public decimal Salario => salario;

        protected Funcionario4(string nome, decimal salario)
        {
            this.nome = nome;
            this.salario = salario;
        }

        public static Funcionario4 CriarFuncionario(TipoFuncionario4 tipo, string nome, decimal salario)
        {
            switch (tipo)
            {
                case TipoFuncionario4.Engenheiro:
                    return new Engenheiro1(nome, salario);
                case TipoFuncionario4.Vendedor:
                    return new Vendedor1(nome, salario);
                case TipoFuncionario4.Gerente:
                    return new Gerente1(nome, salario);
                default:
                    throw new ArgumentException("Tipo de funcionário inválido");
            }
        }
    }

    class Engenheiro1 : Funcionario4
    {
        public Engenheiro1(string nome, decimal salario) : base(nome, salario)
        {
            this.tipo = TipoFuncionario4.Engenheiro;
        }
    }

    class Vendedor1 : Funcionario4
    {
        private decimal comissao;
        public decimal Comissao => comissao;

        public Vendedor1(string nome, decimal salario) : base(nome, salario)
        {
            this.tipo = TipoFuncionario4.Vendedor;
        }

        public void DefinirComissao(decimal comissao)
        {
            if (comissao < 0)
            {
                throw new ArgumentException("Comissão não pode ser negativa");
            }

            if (comissao > .25m)
            {
                throw new ArgumentException("Comissão não pode exceder 25%");
            }

            this.comissao = comissao;
        }
    }

    class Gerente1 : Funcionario4
    {
        private decimal bonus;
        public decimal Bonus => bonus;

        public Gerente1(string nome, decimal salario) : base(nome, salario)
        {
            this.tipo = TipoFuncionario4.Gerente;
        }

        public void DefinirBonus(decimal bonus)
        {
            if (bonus < 0)
            {
                throw new ArgumentException("Bônus não pode ser negativo");
            }

            if (bonus > salario)
            {
                throw new ArgumentException("Bônus não pode ser maior que o salário");
            }

            this.bonus = bonus;
        }
    }
}
