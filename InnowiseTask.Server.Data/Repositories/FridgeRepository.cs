using InnowiseTask.Server.Data.Models;
using InnowiseTask.Server.Data.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace InnowiseTask.Server.Data.Repositories
{
    public class FridgeRepository : RepositoryBase<Fridge>, IFridgeRepository
    {
        public FridgeRepository(ApplicationDbContext context)
            : base(context)
        {
        }

        public async Task<IEnumerable<Fridge>> GetAllFridgesAsync()
        {
            return await GetAllAsync();
        }

        public Fridge GetFridge(Guid id)
        {
            return GetById(id);
        }

        public async Task<Fridge> GetFridgeAsync(Guid id)
        {
            return await GetAsync(id);
        }

    }
}
