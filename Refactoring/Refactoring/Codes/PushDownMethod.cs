using System;

namespace Refactoring.Codes
{
    public static class PushDownMethod
    {
        public static void PushDownMethodMain()
        {
            var engenheiro = Funcionario3.CriarFuncionario(Funcionario3.TipoFuncionario3.Engenheiro, "José da Silva", 1000);
            var vendedor = Funcionario3.CriarFuncionario(Funcionario3.TipoFuncionario3.Vendedor, "Maria Bonita", 2000);
            var gerente = Funcionario3.CriarFuncionario(Funcionario3.TipoFuncionario3.Gerente, "João das Neves", 3000);

            var valorFolhaDePagamento =
                engenheiro.Salario
                + vendedor.Salario
                + gerente.Salario;
        }
    }

    abstract class Funcionario3
    {
        public enum TipoFuncionario3
        {
            Engenheiro = 0,
            Vendedor = 1,
            Gerente = 2
        }

        protected TipoFuncionario3 tipo;
        public TipoFuncionario3 Tipo { get; }

        protected string nome;
        public string Nome => nome;

        protected decimal salario;
        public decimal Salario => salario;

        protected decimal comissao;
        public decimal Comissao => comissao;

        protected decimal bonus;
        public decimal Bonus => bonus;

        protected Funcionario3(string nome, decimal salario)
        {
            this.nome = nome;
            this.salario = salario;
        }

        public static Funcionario3 CriarFuncionario(TipoFuncionario3 tipo, string nome, decimal salario)
        {
            switch (tipo)
            {
                case TipoFuncionario3.Engenheiro:
                    return new Engenheiro(nome, salario);
                case TipoFuncionario3.Vendedor:
                    return new Vendedor(nome, salario);
                case TipoFuncionario3.Gerente:
                    return new Gerente(nome, salario);
                default:
                    throw new ArgumentException("Tipo de funcionário inválido");
            }
        }

    }

    class Engenheiro : Funcionario3
    {
        public Engenheiro(string nome, decimal salario) : base(nome, salario)
        {
            this.tipo = TipoFuncionario3.Engenheiro;
        }
    }

    class Vendedor : Funcionario3
    {
        public Vendedor(string nome, decimal salario) : base(nome, salario)
        {
            this.tipo = TipoFuncionario3.Vendedor;
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

    class Gerente : Funcionario3
    {
        public Gerente(string nome, decimal salario) : base(nome, salario)
        {
            this.tipo = TipoFuncionario3.Gerente;
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
