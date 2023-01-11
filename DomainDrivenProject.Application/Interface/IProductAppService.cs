using DomainDrivenProject.Domain.Entities;
using System.Collections.Generic;

namespace DomainDrivenProject.Application.Interface
{
    public interface IProductAppService : IAppServiceBase<Product>
    {
        IEnumerable<Product> GetByName(string name);
    }
}
