using System;
using System.Collections;
using NHibernate.Transform;
using PracticeNHibernate.DAO;
using PracticeNHibernate.Entities;
using PracticeNHibernate.Infra;

namespace PracticeNHibernate
{
    class Program
    {
        static void Main(string[] args)
        {
            Main1();
            Main2();
            Main3();
            Main4();
            Main5();
            Main6();
            Main7();
            Main8();
            Main9();
        }

        static void Main1()
        {
            var _session = NHibernateHelper.OpenSession();
            var daoUser = new UserDAO(_session);

            var user = new PhysicalPerson
            {
                Name = "Murilo"
            };

            daoUser.Add(user);

            _session.Close();

            Console.Read();
        }

        static void Main2()
        {
            var category = new Category
            {
                Name = "One Category"
            };

            var product = new Product
            {
                Name = "T-Shirt",
                Price = 10,
                Category = category
            };

            var _session = NHibernateHelper.OpenSession();
            var transaction = _session.BeginTransaction();
            _session.Save(category);
            _session.Save(product);
            transaction.Commit();
            _session.Close();

            Console.Read();
        }

        static void Main3()
        {
            var _session = NHibernateHelper.OpenSession();
            var transaction = _session.BeginTransaction();

            var category = _session.Load<Category>(1);
            var product = category.Products;

            transaction.Commit();
            _session.Close();

            Console.Read();
        }

        static void Main4()
        {
            var _session = NHibernateHelper.OpenSession();

            var hql = "select p.Category as Category, count(p) as NumberOfOrders from Product p group by p.Category";
            var query = _session.CreateQuery(hql);
            query.SetResultTransformer(Transformers.AliasToBean<ProductByCategory>());

            var report = query.List<ProductByCategory>();

            _session.Close();

            Console.Read();
        }

        static void Main5()
        {
            var _session = NHibernateHelper.OpenSession();

            var query = _session.CreateQuery("from Product p join fetch p.Category");
            var products = query.List<Product>();
            var categories = query.List<Category>();

            foreach (Product product in products)
            ///foreach(var cat in categories)
            {
                Console.WriteLine(product.Name + "-" + product.Category.Name);

            }

            _session.CreateQuery("select distinct c from Category c join fetch c.Products");
            foreach(var cat in categories)
            {
                Console.WriteLine(cat.Name + "-" + cat.Products.Count);

            }

            _session.Close();

            Console.Read();
        }

        static void Main6()
        {
            var _session = NHibernateHelper.OpenSession();

            var productDAO = new ProductDAO(_session);

            var products = productDAO.SearchNameMinimumPriceAndCategory("", 20, "Roupas");

            foreach(var product in products)
            {
                Console.WriteLine($"Name: {product.Name}. Price: {product.Price.ToString()}. Category:{product.Category.Name}");
            }

            _session.Close();

            Console.Read();
        }

        static void Main7()
        {
            var _session = NHibernateHelper.OpenSession();
            var _session2 = NHibernateHelper.OpenSession();

            var category = _session.Get<Category>(1);
            var category2 = _session2.Get<Category>(1);

            Console.WriteLine(category.Products.Count);
            Console.WriteLine(category2.Products.Count);

            _session.CreateQuery("from User").SetCacheable(true).List<User>();
            _session2.CreateQuery("from User").SetCacheable(true).List<User>();

            _session.Close();

            Console.Read();
        }

        static void Main8()
        {
            var _session = NHibernateHelper.OpenSession();
            var transaction = _session.BeginTransaction();

            var sale = new Sale
            {
                Client = _session.Get<User>(1)
            };

            var product = _session.Get<Product>(1);
            var product2 = _session.Get<Product>(2);

            sale.Products.Add(product);
            sale.Products.Add(product2);

            _session.Save(sale);

            transaction.Commit();
            _session.Close();

            Console.Read();
        }

        static void Main9()
        {
            var murilo = new PhysicalPerson
            {
                Name = "Murilo",
                CPF = 11233433.ToString()
            };

            var caelum = new LegalPerson
            {
                Name = "Murilo",
                CNPJ = 11233433.ToString()
            };

            var _session = NHibernateHelper.OpenSession();
            var userDAO = new UserDAO(_session);

            userDAO.Add(murilo);
            userDAO.Add(caelum);

            _session.Close();
            Console.Read();
        }

        public class ProductByCategory
        {
            public Category Category { get; set; }
            public long NumberOfOrders { get; set; }
        }
    }
}