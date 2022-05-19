using InnowiseTask.Server.Data.Models.Base;
using InnowiseTask.Server.Data.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace InnowiseTask.Server.Data.Repositories
{
    public class RepositoryBase<TModel> : IRepositoryBase<TModel> where TModel : BaseModel
    {
        private readonly ApplicationDbContext _context;
        private readonly DbSet<TModel> _dbSet;

        public RepositoryBase(ApplicationDbContext context)
        {
            _context = context;
            _dbSet = context.Set<TModel>();
        }
        public async Task<IEnumerable<TModel>> GetAllAsync()
        {
            return await _dbSet.ToListAsync();
        }
        public async Task<TModel> GetAsync(Guid id)
        {
            return await _dbSet.FirstOrDefaultAsync(x => x.Id == id);
        }

        public void Create(TModel model)
        {
            _dbSet.Add(model);
        }

        public void Delete(TModel model)
        {
            _dbSet.Remove(model);
        }

        public void Update(TModel model)
        {
            _dbSet.Update(model);
        }

        public TModel GetById(Guid id)
        {
            return _dbSet.FirstOrDefault(f => f.Id == id);
        }
    }
}
