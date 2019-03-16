using System.Collections.Generic;

namespace PracticeNHibernate.Entities
{
    public class Category
    {
        public virtual int Id { get; set; }
        public string Name { get; set; }

        public IList<Product> Products { get; set; }
    }
}