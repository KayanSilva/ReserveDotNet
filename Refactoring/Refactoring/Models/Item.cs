namespace Refactoring.Models
{
    class Item
    {
        const decimal TaxRate = 0.3m;
        public decimal UnitPrice { get; }
        public int Quantity { get; }
        internal Product Produto { get; }

        public decimal TotalTaxes => (Quantity * UnitPrice) * (1.0m + TaxRate);
        public decimal Total => Quantity * UnitPrice;

        public Item(Product product, decimal unitprice, int quantity)
        {
            Produto = product;
            UnitPrice = unitprice;
            Quantity = quantity;
        }
    }
}