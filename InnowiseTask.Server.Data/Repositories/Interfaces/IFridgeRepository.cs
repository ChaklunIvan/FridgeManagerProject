using InnowiseTask.Server.Data.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace InnowiseTask.Server.Data.Repositories.Interfaces
{
    public interface IFridgeRepository
    {
        Task <IEnumerable<Fridge>> GetAllFridgesAsync();
        Task<Fridge> GetFridgeAsync(Guid id);
        Fridge GetFridge(Guid id);


    }
}
