using System.Threading.Tasks;

namespace InnowiseTask.Server.Data.Repositories.Interfaces
{
    public interface IRepositoryManager
    {
        IFridgeRepository Fridge { get; }
        IProductRepository Product { get; }
        IFridgeModelRepository FridgeModel { get; }
        IFridgeProductRepository FridgeProduct { get; }
        Task SaveAsync();
    }
}
