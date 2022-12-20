using DomainDrivenProject.Domain.Entities;
using DomainDrivenProject.Domain.Interfaces;

namespace DomainDrivenProject.Infra.Data.Repositories
{
    public class ClientRepository : RepositoryBase<Client>, IClientRepository
    {
    }
}
