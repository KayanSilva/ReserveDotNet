﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using NHibernate.Cfg;
using NHibernate.Tool.hbm2ddl;

namespace PracticeNHibernate.Infra
{
    public class NHibernateHelper
    {
        public static Configuration RecuperaConfiguracao()
        {
            Configuration cfg = new Configuration();
            cfg.Configure();
            cfg.AddAssembly(Assembly.GetExecutingAssembly());

            return cfg;
        }

        public static void GeraSchema()
        {
            Configuration cfg = RecuperaConfiguracao();
            new SchemaExport(cfg).Create(true, true);
        }
    }
}
