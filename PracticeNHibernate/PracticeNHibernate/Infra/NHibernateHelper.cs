using System.Reflection;
using NHibernate;
using NHibernate.Cfg;
using NHibernate.Tool.hbm2ddl;

namespace PracticeNHibernate.Infra
{
    public class NHibernateHelper
    {
        private static ISessionFactory fabric = CreateSessionFactory();

        private static ISessionFactory CreateSessionFactory()
        {
            var cfg = RecuperaConfiguracao();
            return cfg.BuildSessionFactory();
        }

        public static Configuration RecuperaConfiguracao()
        {
            var cfg = new Configuration();
            cfg.Configure();
            cfg.AddAssembly(Assembly.GetExecutingAssembly());

            return cfg;
        }

        public static void GeraSchema()
        {
            var cfg = RecuperaConfiguracao();
            new SchemaExport(cfg).Create(true, true);
        }

        public static ISession OpenSession()
        {
            return fabric.OpenSession();
        }
    }
}