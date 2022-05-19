using InnowiseTask.Server.Data.Models;
using System;

namespace InnowiseTask.Server.Data.Repositories.Interfaces
{
    public interface IFridgeModelRepository
    {
        FridgeModel GetFridgeModel(Guid id);
    }
}
