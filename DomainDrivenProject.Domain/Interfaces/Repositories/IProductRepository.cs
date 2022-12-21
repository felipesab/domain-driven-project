using DomainDrivenProject.Domain.Entities;
using System.Collections.Generic;

namespace DomainDrivenProject.Domain.Interfaces.Repositories
{
    public interface IProductRepository : IRepositoryBase<Product>
    {
        IEnumerable<Product> GetByName(string name);
    }
}
