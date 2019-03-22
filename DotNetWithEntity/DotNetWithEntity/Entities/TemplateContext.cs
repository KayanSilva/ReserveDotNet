using DotNetWithEntity.Models;
using Microsoft.EntityFrameworkCore;

namespace DotNetWithEntity.Entities
{
    public class TemplateContext : DbContext
    {
        public TemplateContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Template> Templates { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Template>()
                .ToTable("Template");
        }
    }
}