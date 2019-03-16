using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeNHibernate.Entities
{
    public class LegalPerson : User
    {
        public virtual string CNPJ { get; set; }
    }
}
