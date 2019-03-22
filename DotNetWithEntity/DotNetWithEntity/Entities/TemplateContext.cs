using DotNetWithEntity.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotNetWithEntity.Entities
{
    public class TemplateContext : DbContext
    {
        public TemplateContext(DbContextOptions options) : base(options) { }

        public DbSet<Template> Templates { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Template>()
                .ToTable("Template");
        }
    }
}
