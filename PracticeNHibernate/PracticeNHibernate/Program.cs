using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PracticeNHibernate.Infra;

namespace PracticeNHibernate
{
    class Program
    {
        static void Main(string[] args)
        {
            NHibernateHelper.GeraSchema();

            Console.Read();
        }
    }
}
