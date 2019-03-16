using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NHibernate;
using PracticeNHibernate.Entities;
using PracticeNHibernate.Infra;

namespace PracticeNHibernate.DAO
{
    public class UserDAO
    {
        private ISession _session;

        public UserDAO(ISession session)
        {
            _session = session;
        }

        public void Add(User user)
        {
            var transaction = _session.BeginTransaction();
            _session.Save(user);
            transaction.Commit();
        }

        public User SearchId(int id)
        {
            return _session.Get<User>(id);
        }
    }
}
