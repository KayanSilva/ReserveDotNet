namespace Refactoring.Models
{
    class Product
    {
        public string Nome { get; }
        public decimal PrecoUnitario { get; }

        public Product(string nome, decimal precoUnitario)
        {
            Nome = nome;
            PrecoUnitario = precoUnitario;
        }
    }
}