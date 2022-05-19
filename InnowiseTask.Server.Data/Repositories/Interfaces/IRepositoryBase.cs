using InnowiseTask.Server.Data.Models.Base;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace InnowiseTask.Server.Data.Repositories.Interfaces
{
    public interface IRepositoryBase<TModel> where TModel : BaseModel
    {
        Task<IEnumerable<TModel>> GetAllAsync();
        Task<TModel> GetAsync(Guid id);
        TModel GetById(Guid id);
        void Create(TModel model);
        void Update(TModel model);
        void Delete(TModel model);
    }
}
