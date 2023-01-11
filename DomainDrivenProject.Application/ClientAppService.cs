using DomainDrivenProject.Application.Interface;
using DomainDrivenProject.Domain.Entities;
using DomainDrivenProject.Domain.Interfaces.Services;
using System.Collections.Generic;

namespace DomainDrivenProject.Application
{
    public class ClientAppService : AppServiceBase<Client>, IClientAppService
    {
        private readonly IClientService _clientService;
        public ClientAppService(IClientService clientService)
            :base(clientService)
        {
            _clientService = clientService;
        }

        public IEnumerable<Client> GetSpecialClients()
        {
            return _clientService.GetSpecialClients(_clientService.GetAll());
        }
    }
}
