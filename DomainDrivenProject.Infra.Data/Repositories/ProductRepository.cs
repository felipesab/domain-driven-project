using DomainDrivenProject.Domain.Entities;
using DomainDrivenProject.Domain.Interfaces.Repositories;
using System.Collections.Generic;
using System.Linq;

namespace DomainDrivenProject.Infra.Data.Repositories
{
    public class ProductRepository : RepositoryBase<Product>, IProductRepository
    {
        public IEnumerable<Product> GetByName(string name)
        {
            return context.Products.Where(p => p.Name == name).ToList();
        }
    }
}
