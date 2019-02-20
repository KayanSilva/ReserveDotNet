namespace Refactoring.Models
{
    abstract class ServiceItem
    {
        private readonly int Quantity;

        protected ServiceItem(int quantity)
        {
            Quantity = quantity;
        }
        public decimal GetTotalPrice()
        {
            return Quantity * GetUnitPrice();
        }
        public int GetQuantity()
        {
            return Quantity;
        }
        public abstract decimal GetUnitPrice();
    }
}