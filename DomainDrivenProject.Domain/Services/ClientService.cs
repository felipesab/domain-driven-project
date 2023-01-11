using DomainDrivenProject.Domain.Entities;
using DomainDrivenProject.Domain.Interfaces.Repositories;
using DomainDrivenProject.Domain.Interfaces.Services;
using System.Collections.Generic;
using System.Linq;

namespace DomainDrivenProject.Domain.Services
{
    public class ClientService : ServiceBase<Client>, IClientService
    {
        private readonly IClientRepository _clientRepository;

        public ClientService(IClientRepository clientRepository) :
            base(clientRepository)
        {
            _clientRepository = clientRepository;
        }

        public IEnumerable<Client> GetSpecialClients(IEnumerable<Client> clients)
        {
            return clients.Where(c => c.SpecialClient(c));
        }
    }
}
