using DomainDrivenProject.Domain.Entities;
using System.Collections.Generic;

namespace DomainDrivenProject.Application.Interface
{
    public interface IClientAppService : IAppServiceBase<Client>
    {
        IEnumerable<Client> GetSpecialClients();
    }
}
