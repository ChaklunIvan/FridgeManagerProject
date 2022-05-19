using InnowiseTask.Server.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InnowiseTask.Server.Services.Interfaces
{
    public interface IFridgeManager
    {
        Task<IEnumerable<FridgeProduct>> AddProducts(IList<Guid> productId, Guid fridgeId);
        Task RemoveProducts(IList<Guid> productsId, Guid fridgeId);
        Task<FridgeProduct> AddProducts(Guid productId, Guid fridgeId);
        Task RemoveProducts(Guid productId, Guid fridgeId);
        void LehinaZadacha(List<DateTime> dateTimes1, List<DateTime> dateTimes2);
    }
}
