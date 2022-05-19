using InnowiseTask.Server.Data.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace InnowiseTask.Server.Data.Repositories.Interfaces
{
    public interface IProductRepository
    {
        Task<IEnumerable<Product>> GetAllProductsAsync();
        Task<IEnumerable<Product>> GetProductsAsync(IList<Guid> id);
        Task<Product> GetProductsAsync(Guid id);
        Product GetProduct(Guid id);
    }
}
