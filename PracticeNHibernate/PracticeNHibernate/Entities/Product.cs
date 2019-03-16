namespace PracticeNHibernate.Entities
{
    public class Product
    {
        public virtual int Id { get; set; }
        public virtual string Name { get; set; }
        public virtual decimal Price { get; set; }
        public Category Category { get; set; }
    }
}