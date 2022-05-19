using InnowiseTask.Server.Data.Models;
using InnowiseTask.Server.Data.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InnowiseTask.Server.Data.Repositories
{
    public class FridgeProductRepository : RepositoryBase<FridgeProduct>, IFridgeProductRepository
    {
        public FridgeProductRepository(ApplicationDbContext context)
            : base(context)
        {
        }

        public void AddFridgeProduct(FridgeProduct model)
        {
            Create(model);
        }

        public async Task<IEnumerable<FridgeProduct>> GetAllFridgeProductsAsync()
        {
            return await GetAllAsync();
        }

        public async Task<FridgeProduct> GetFridgeProductAsync(Guid id)
        {
            return await GetAsync(id);
        }

        public void RemoveFridgeProduct(FridgeProduct model)
        {
            Delete(model);
        }
    }
}
