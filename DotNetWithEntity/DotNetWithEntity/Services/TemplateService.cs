using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using DotNetWithEntity.Entities;
using DotNetWithEntity.Interfaces;
using DotNetWithEntity.Models;
using Microsoft.EntityFrameworkCore;

namespace DotNetWithEntity.Services
{
    public class TemplateService : ITemplateService
    {
        private readonly TemplateContext _context;

        public TemplateService(TemplateContext context)
        {
            _context = context;
        }

        public async Task<bool> Create(Template template)
        {
            var success = false;
            try
            {
                _context.Templates.Add(template);
                await _context.SaveChangesAsync();
                success = true;
            }
            catch (Exception)
            {
                success = false;
                throw;
            }

            return success;
        }

        public async Task<IEnumerable<Template>> GetTemplates(Client client)
        {
            return await _context.Templates.ToListAsync();
        }

        public async Task<bool> Update(Template template)
        {
            var success = false;
            try
            {
                _context.Entry(template).State = EntityState.Modified;
                await _context.SaveChangesAsync();
                success = true;
            }
            catch (Exception)
            {
                success = false;
                throw;
            }

            return success;
        }
    }
}