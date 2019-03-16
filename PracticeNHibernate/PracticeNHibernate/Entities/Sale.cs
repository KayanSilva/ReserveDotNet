using System.Collections.Generic;

namespace PracticeNHibernate.Entities
{
    public class Sale
    {
        public virtual int Id { get; set; }
        public virtual User Client { get; set; }
        public virtual IList<Product> Products { get; set; }

        public Sale()
        {
            Products = new List<Product>();
        }
    }
}