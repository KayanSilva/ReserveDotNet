namespace Refactoring.Codes
{
    public class ReplaceParameterWithExplicitMethods
    {
        void ReplaceParameterWithExplicitMethodsMain()
        {
            var funcionario1 = new Funcionario2("Tony Estarque", 10000);
            var funcionario2 = new Funcionario2("Pedro Parques", 2000);

            funcionario1.DarAumentoFixo(3000);
            funcionario2.DarAumentoPorcentual(10);
        }
    }

    class Funcionario2
    {
        public const int TIPO_AUMENTO_FIXO = 0;
        public const int TIPO_AUMENTO_PORCENTUAL = 1;

        readonly string nome;
        public string Nome => nome;

        decimal salario;
        public decimal Salario => salario;

        public Funcionario2(string nome, decimal salario)
        {
            this.nome = nome;
            this.salario = salario;
        }

        public void DarAumentoFixo(decimal aumento)
        {
            salario += aumento;
        }

        public void DarAumentoPorcentual(decimal aumento)
        {
            salario *= (1.0m + aumento / 100.0m);
        }
    }
}