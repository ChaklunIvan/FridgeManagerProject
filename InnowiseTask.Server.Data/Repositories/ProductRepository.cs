using InnowiseTask.Server.Data.Models;
using InnowiseTask.Server.Data.Repositories.Interfaces;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace InnowiseTask.Server.Data.Repositories
{
    public class ProductRepository : RepositoryBase<Product>, IProductRepository
    {
        public ProductRepository(ApplicationDbContext context) 
            : base(context)
        {
        }

        public Product GetProduct(Guid id)
        {
            return GetById(id);
        }

        public async Task<Product> GetProductsAsync(Guid id)
        {
            return await GetAsync(id);
        }

        public async Task<IEnumerable<Product>> GetAllProductsAsync()
        {
            return await GetAllAsync();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id">List of Guid</param>
        /// <returns>products list without distinct.</returns>
        public async Task<IEnumerable<Product>> GetProductsAsync(IList<Guid> id)
        {
            var products = await GetAllAsync();
            var result = new List<Product>();
            foreach(var product in products)
            {
                foreach(var i in id)
                {
                    if(i == product.Id)
                    {
                        result.Add(product);
                    }
                }
            }
            return result;
        }
    }
}
