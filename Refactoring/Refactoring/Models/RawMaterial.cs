namespace Refactoring.Models
{
    class RawMaterial : ServiceItem
    {
        private readonly decimal UnitPrice;

        public RawMaterial(int quantity, decimal unitPrice)
            : base(quantity)
        {
            UnitPrice = unitPrice;
        }

        public override decimal GetUnitPrice()
        {
            return UnitPrice;
        }
    }
}