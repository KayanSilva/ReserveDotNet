using DotNetWithEntity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotNetWithEntity.Interfaces
{
    public interface ITemplateService
    {
        Task<IEnumerable<Template>> GetTemplates(Client client);

        Task<bool> Create(Template template);

        Task<bool> Update(Template template);
    }
}