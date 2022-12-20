using DomainDrivenProject.Domain.Entities;
using System.Collections.Generic;

namespace DomainDrivenProject.Domain.Interfaces
{
    public interface IProductRepository : IRepositoryBase<Product>
    {
        IEnumerable<Product> GetByName(string name);
    }
}
