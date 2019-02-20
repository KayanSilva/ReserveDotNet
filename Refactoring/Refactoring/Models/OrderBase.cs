using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace Refactoring.Models
{
    abstract class OrderBase
    {
        public string ClientName { get; set; }
        public string DeliveryAddress { get; set; }

        protected readonly List<Item> itens = new List<Item>();
        internal IReadOnlyCollection<Item> Itens => new ReadOnlyCollection<Item>(itens);

        public decimal ValueOfItems()
        {
            return itens.Sum(i => i.Total);
        }
    }
}