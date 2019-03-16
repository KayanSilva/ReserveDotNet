using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NHibernate;
using NHibernate.Criterion;
using PracticeNHibernate.Entities;

namespace PracticeNHibernate.DAO
{
    class ProductDAO
    {
        private ISession _session;

        public ProductDAO(ISession session)
        {
            _session = session;
        }

        public void Add(Product user)
        {
            var transaction = _session.BeginTransaction();
            _session.Save(user);
            transaction.Commit();
        }

        public Product SearchId(int id)
        {
            return _session.Get<Product>(id);
        }

        public IList<Product> SearchNameMinimumPriceAndCategory(string name, decimal minimumprice, string category)
        {
            ICriteria criteria = _session.CreateCriteria<Product>();

            if (!string.IsNullOrEmpty(name))
                criteria.Add(Restrictions.Eq("Name", name));

            if (minimumprice > 0)
                criteria.Add(Restrictions.Eq("Price", minimumprice));

            if (!string.IsNullOrEmpty(category))
            {
                var criteriaCategory = _session.CreateCriteria("Category");
                criteriaCategory.Add(Restrictions.Eq("Name", category));
            }

            return criteria.List<Product>();
        }
    }
}
