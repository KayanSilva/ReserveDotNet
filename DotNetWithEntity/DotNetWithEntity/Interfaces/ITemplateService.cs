using System.Collections.Generic;
using System.Threading.Tasks;
using DotNetWithEntity.Models;

namespace DotNetWithEntity.Interfaces
{
    public interface ITemplateService
    {
        Task<IEnumerable<Template>> GetTemplates(Client client);

        Task<bool> Create(Template template);

        Task<bool> Update(Template template);
    }
}