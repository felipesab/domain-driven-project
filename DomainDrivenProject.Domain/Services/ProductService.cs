using DomainDrivenProject.Domain.Entities;
using DomainDrivenProject.Domain.Interfaces.Repositories;
using DomainDrivenProject.Domain.Interfaces.Services;
using System.Collections.Generic;

namespace DomainDrivenProject.Domain.Services
{
    public class ProductService : ServiceBase<Product>, IProductService
    {
        private readonly IProductRepository _productRepository;

        public ProductService(IProductRepository productRepository)
            : base(productRepository)
        {
            _productRepository = productRepository;
        }

        public IEnumerable<Product> GetByName(string name)
        {
            return _productRepository.GetByName(name);
        }
    }
}
