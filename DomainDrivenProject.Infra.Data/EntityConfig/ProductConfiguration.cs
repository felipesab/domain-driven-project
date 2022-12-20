using DomainDrivenProject.Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace DomainDrivenProject.Infra.Data.EntityConfig
{
    public class ProductConfiguration : EntityTypeConfiguration<Product>
    {
        public ProductConfiguration()
        {
            Property(p => p.Name)
                .IsRequired()
                .HasMaxLength(250);

            Property(p => p.Price)
                .IsRequired();

            HasRequired(p => p.Client)
                .WithMany()
                .HasForeignKey(p => p.ClientId);
        }
    }
}
