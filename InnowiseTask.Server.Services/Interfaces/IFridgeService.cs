using InnowiseTask.Server.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InnowiseTask.Server.Services.Interfaces
{
    public interface IFridgeService
    {
        Task<IEnumerable<Product>> ProductsInFridge(Guid fridgeId);
        Task<IEnumerable<FridgeProduct>> AddProducts(IList<Guid> productId, Guid fridgeId);
        Task<FridgeProduct> AddProducts(Guid productId, Guid fridgeId);
        Task RemoveProducts(IList<Guid> productsId, Guid fridgeId);
        Task RemoveProducts(Guid productId, Guid fridgeId);
        Task<int> TakeProduct(Guid productId, Guid fridgeId, int quantity);
    }
}
