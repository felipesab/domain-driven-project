using DomainDrivenProject.Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace DomainDrivenProject.Infra.Data.EntityConfig
{
    public class ClientConfiguration : EntityTypeConfiguration<Client>
    {
        public ClientConfiguration()
        {
            Property(p => p.Name)
                .IsRequired()
                .HasMaxLength(150);

            Property(p => p.Surname)
                .IsRequired()
                .HasMaxLength(150);

            Property(p => p.Email)
                .IsRequired();
        }
    }
}
