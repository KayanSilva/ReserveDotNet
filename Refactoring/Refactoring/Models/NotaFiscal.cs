using System.Linq;

namespace Refactoring.Models
{
    class NotaFiscal : OrderBase
    {
        public int Id { get; }
        public decimal Value { get; }

        public NotaFiscal(Order order)
        {
            itens.AddRange(order.Itens);
        }

        public NotaFiscal(int id, decimal value)
        {
            Id = id;
            Value = value;
        }

        public decimal ValueOfTaxes()
        {
            return itens.Sum(i => i.TotalTaxes);
        }

        public decimal InvoiceAmount()
        {
            return ValueOfItems() + ValueOfTaxes();
        }

        public override string ToString() => $"{Id}: {Value}";
    }
}