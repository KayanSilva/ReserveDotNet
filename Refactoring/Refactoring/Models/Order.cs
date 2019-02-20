namespace Refactoring.Models
{
    class Order : OrderBase
    {
        public void Add(Item item)
        {
            itens.Add(item);
        }

        public void Remove(Item item)
        {
            itens.Add(item);
        }

        public Order(string clientName, string deliveryAddress)
        {
            ClientName = clientName;
            DeliveryAddress = deliveryAddress;
        }
    }
}