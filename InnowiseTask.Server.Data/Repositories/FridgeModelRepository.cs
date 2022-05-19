using InnowiseTask.Server.Data.Models;
using InnowiseTask.Server.Data.Repositories.Interfaces;
using System;

namespace InnowiseTask.Server.Data.Repositories
{
    public class FridgeModelRepository : RepositoryBase<FridgeModel>, IFridgeModelRepository
    {
        public FridgeModelRepository(ApplicationDbContext context) 
            : base(context)
        {
        }

        public FridgeModel GetFridgeModel(Guid id)
        {
            return GetById(id);
        }
    }
}
