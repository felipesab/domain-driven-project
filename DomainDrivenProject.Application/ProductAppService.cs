using DomainDrivenProject.Application.Interface;
using DomainDrivenProject.Domain.Entities;
using DomainDrivenProject.Domain.Interfaces.Services;
using System.Collections.Generic;

namespace DomainDrivenProject.Application
{
    public class ProductAppService : AppServiceBase<Product>, IProductAppService
    {
        private readonly IProductService _productService;

        public ProductAppService(IProductService productService)
            :base(productService)
        {
            _productService = productService;
        }

        public IEnumerable<Product> GetByName(string name)
        {
            return _productService.GetByName(name);
        }
    }
}
