using DomainDrivenProject.Domain.Entities;
using System.Collections.Generic;

namespace DomainDrivenProject.Domain.Interfaces.Services
{
    public interface IProductService : IServiceBase<Product>
    {
        IEnumerable<Product> GetByName(string name);
    }
}
