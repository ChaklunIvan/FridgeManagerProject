using InnowiseTask.Server.Data.Repositories.Interfaces;
using System.Threading.Tasks;

namespace InnowiseTask.Server.Data.Repositories
{
    public class RepositoryManager : IRepositoryManager
    {
        private readonly ApplicationDbContext _context;

        private IFridgeRepository _fridgeRepository;
        private IProductRepository _productRepository;
        private IFridgeModelRepository _fridgeModelRepository;
        private IFridgeProductRepository _fridgeProductRepository;

        public RepositoryManager(ApplicationDbContext context)
        {
            _context = context;
        }

        public IFridgeRepository Fridge
        {
            get 
            {
                if(_fridgeRepository == null)
                    _fridgeRepository = new FridgeRepository(_context);

                return _fridgeRepository; 
            }
        }
        public IProductRepository Product
        {
            get
            {
                if(_productRepository == null)
                    _productRepository = new ProductRepository(_context);
                return _productRepository;
            }
        }
        public IFridgeModelRepository FridgeModel
        {
            get
            {
                if(null == _fridgeModelRepository) 
                    _fridgeModelRepository = new FridgeModelRepository(_context);
                return _fridgeModelRepository;
            }
        }

        public IFridgeProductRepository FridgeProduct
        {
            get
            {
                if (null == _fridgeProductRepository)
                    _fridgeProductRepository = new FridgeProductRepository(_context);
                return _fridgeProductRepository;
            }
        }

        public async Task SaveAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}
