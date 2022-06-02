using InnowiseTask.Server.Data.Models;
using InnowiseTask.Server.Data.Repositories.Interfaces;
using InnowiseTask.Server.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InnowiseTask.Server.Services
{
    public class FridgeService : IFridgeService
    {
        private readonly IRepositoryManager _repository;
        private readonly ILoggerManager _logger;

        public FridgeService(IRepositoryManager repository, ILoggerManager logger)
        {
            _repository = repository;
            _logger = logger;
        }

        public async Task<IEnumerable<Product>> ProductsInFridge(Guid fridgeId)
        {
            var fridge = await _repository.Fridge.GetFridgeAsync(fridgeId);
            if (fridge == null)
            {
                _logger.LogError($"Fridge with id: {fridgeId} doesnt exist in the database.");
                throw new NullReferenceException($"{fridge} is null");
            }
            var fridgeProducts = await _repository.FridgeProduct.GetAllFridgeProductsAsync();
            var products = await _repository.Product.GetAllProductsAsync();
            if (products == null)
            {
                _logger.LogInfo($"Fridge with id: {fridgeId} doesnt contains any products");
            }

            var resultProducts = fridge.FridgeProducts.Select(s => s.Product).ToList();

            return resultProducts;
        }

        public async Task<FridgeProduct> AddProducts(Guid productId, Guid fridgeId)
        {
            var fridge = await _repository.Fridge.GetFridgeAsync(fridgeId);
            var product = await _repository.Product.GetProductsAsync(productId);
            if (fridge == null)
            {
                _logger.LogError($"Fridge with id: {fridgeId} doesnt exist in the database.");
                throw new NullReferenceException($"{fridge} is null");
            }
            if (product == null)
            {
                _logger.LogError($"Product with id: {productId} doesnt exist in the database.");
                throw new NullReferenceException($"{product} is null");
            }

            var fridgeProducts = await _repository.FridgeProduct.GetAllFridgeProductsAsync();
            var fp = fridgeProducts.Where(f => f.FridgeId == fridgeId).ToList();
            if (fp != null && fp.Select(p => p.ProductId).Contains(product.Id))
            {
                var fridgeProduct = fridgeProducts.FirstOrDefault(p => p.ProductId == product.Id);
                fridgeProduct.Quantity += (int)product.DefaultQuantity;
                await _repository.SaveAsync();
                return fridgeProduct;

            }
            else
            {
                var fridgeProduct = new FridgeProduct
                {
                    Id = Guid.NewGuid(),
                    Fridge = fridge,
                    Product = product,
                    FridgeId = fridge.Id,
                    ProductId = product.Id,
                    Quantity = (int)product.DefaultQuantity
                };
                _repository.FridgeProduct.AddFridgeProduct(fridgeProduct);
                await _repository.SaveAsync();
                return fridgeProduct;
            }

        }

        public async Task<IEnumerable<FridgeProduct>> AddProducts(IList<Guid> productsId, Guid fridgeId)
        {
            var fridge = await _repository.Fridge.GetFridgeAsync(fridgeId);
            var productsList = await _repository.Product.GetProductsAsync(productsId);
            var fpList = new List<FridgeProduct>();
            if (productsList.Count() < productsId.Count)
            {
                _logger.LogWarning($"Some products doesnt exist in the database. And will be removed from list.");
            }
            if (fridge == null)
            {
                _logger.LogError($"Fridge with id: {fridgeId} doesnt exist in the database.");
                throw new NullReferenceException($"{fridge} is null");
            }
            if (productsList == null)
            {
                _logger.LogError($"Products with ids: {productsId} doesnt exist in the database.");
                throw new NullReferenceException($"{productsList} is null");

            }

            var fridgeProducts = await _repository.FridgeProduct.GetAllFridgeProductsAsync();
            var productsToAdd = productsList;
            if (fridge.FridgeProducts != null)
            {
                productsToAdd = productsList.Where(p => !fridge.FridgeProducts.Select(s => s.Product).Contains(p)).ToList();
                foreach (var product in productsToAdd)
                {
                    if (!fridge.FridgeProducts.Select(s => s.Product).Contains(product))
                    {
                        var fridgeProduct = new FridgeProduct
                        {
                            Id = Guid.NewGuid(),
                            Fridge = fridge,
                            Product = product,
                            FridgeId = fridge.Id,
                            ProductId = product.Id,
                            Quantity = (int)product.DefaultQuantity
                        };
                        _repository.FridgeProduct.AddFridgeProduct(fridgeProduct);
                        fpList.Add(fridgeProduct);
                    }
                    else
                    {
                        var fridgeProduct = fridge.FridgeProducts.FirstOrDefault(p => p.ProductId == product.Id);
                        fridgeProduct.Quantity += (int)product.DefaultQuantity;
                        fpList.Add(fridgeProduct);
                    }
                }
            }
            else
            {
                foreach (var product in productsToAdd)
                {
                    if (fridgeProducts.Where(f => f.FridgeId == fridgeId).Select(s => s.ProductId).Contains(product.Id))
                    {
                        var fP = fridgeProducts.FirstOrDefault(p => p.ProductId == product.Id);
                        fP.Quantity += (int)product.DefaultQuantity;
                        fpList.Add(fP);
                    }
                    else
                    {
                        var fridgeProduct = new FridgeProduct
                        {
                            Id = Guid.NewGuid(),
                            Fridge = fridge,
                            Product = product,
                            FridgeId = fridge.Id,
                            ProductId = product.Id,
                            Quantity = (int)product.DefaultQuantity
                        };
                        _repository.FridgeProduct.AddFridgeProduct(fridgeProduct);
                        fpList.Add(fridgeProduct);
                    }
                }
            }

            var productsQuantityToAdd = productsList.Where(p => !productsToAdd.Contains(p)).ToList();
            foreach (var product in productsQuantityToAdd)
            {
                var fridgeProduct = fridge.FridgeProducts.FirstOrDefault(p => p.ProductId == product.Id);
                fridgeProduct.Quantity += (int)product.DefaultQuantity;
                fpList.Add(fridgeProduct);
            }

            await _repository.SaveAsync();
            return fpList;
        }

      

        public async Task RemoveProducts(Guid productId, Guid fridgeId)
        {
            var fridge = await _repository.Fridge.GetFridgeAsync(fridgeId);
            var product = await _repository.Product.GetProductsAsync(productId);
            if (fridge == null)
            {
                _logger.LogError($"Fridge with id: {fridgeId} doesnt exist in the database.");
                throw new NullReferenceException($"{fridge} is null");
            }
            if (product == null)
            {
                _logger.LogError($"Product with id: {productId} doesnt exist in the database.");
                throw new NullReferenceException($"{product} is null");
            }

            var fridgeProducts = await _repository.FridgeProduct.GetAllFridgeProductsAsync();
            if (fridgeProducts == null && fridgeProducts.FirstOrDefault(f => f.Fridge == fridge) == null)
            {
                _logger.LogError($"Fridge: {fridge} is absent");
                throw new NullReferenceException($"{fridgeProducts} is null");
            }


            var productForRemove = fridgeProducts.Where(f => f.FridgeId == fridgeId).FirstOrDefault(p => p.ProductId == productId);
            if(productForRemove != null)
            {
                _repository.FridgeProduct.RemoveFridgeProduct(productForRemove);
                await _repository.SaveAsync();
            }
            else
            {
                _logger.LogInfo($"Product with id: {productId} not stored in fridge {fridgeId}");
            }
        }

        public async Task RemoveProducts(IList<Guid> productsId, Guid fridgeId)
        {
            var fridge = await _repository.Fridge.GetFridgeAsync(fridgeId);
            var products = await _repository.Product.GetProductsAsync(productsId);
            if (products.Count() < productsId.Count)
            {
                _logger.LogWarning($"Some products doesnt exist in the database. And will be removed from list.");
            }
            if (fridge == null)
            {
                _logger.LogError($"Fridge with id: {fridgeId} doesnt exist in the database.");
                throw new NullReferenceException($"{fridge} is null");
            }
            if (products == null)
            {
                _logger.LogError($"Products with ids: {productsId} doesnt exist in the database.");
                throw new NullReferenceException($"{products} is null");
            }

            var fridgeProducts = await _repository.FridgeProduct.GetAllFridgeProductsAsync();
            if(fridgeProducts == null && fridgeProducts.FirstOrDefault(f => f.Fridge == fridge) == null)
            {
                _logger.LogError($"Fridge: {fridge} is absent");
                throw new NullReferenceException($"{fridgeProducts} is null");
            }

            products = fridgeProducts.Where(f => f.Fridge == fridge).Select(p => p.Product).ToList();
            foreach(var product in products)
            {
                if (productsId.Contains(product.Id))
                {
                    _repository.FridgeProduct.RemoveFridgeProduct(fridgeProducts.Where(f => f.Fridge == fridge).FirstOrDefault(fp => fp.ProductId == product.Id));
                    await _repository.SaveAsync();
                }
                else
                {
                    _logger.LogInfo($"Product with id: {product.Id} not stored in fridge: {fridge.Id}");
                }
            }
        }

        public async Task<int> TakeProduct(Guid productId, Guid fridgeId, int quantity)
        {
            var fridge = await _repository.Fridge.GetFridgeAsync(fridgeId);
            var product = await _repository.Product.GetProductsAsync(productId);
            if (fridge == null)
            {
                _logger.LogError($"Fridge with id: {fridgeId} doesnt exist in the database.");
                throw new NullReferenceException($"{fridge} is null");
            }
            if (product == null)
            {
                _logger.LogError($"Products with ids: {productId} doesnt exist in the database.");
                throw new NullReferenceException($"{product} is null");
            }

            var fridgeProducts = await _repository.FridgeProduct.GetAllFridgeProductsAsync();
            var fridgeToTake = fridgeProducts.Where(f => f.Fridge == fridge).FirstOrDefault(p => p.ProductId == product.Id);
            if (fridgeToTake == null)
            {
                _logger.LogError($"Fridge: {fridge} is absent");
                throw new NullReferenceException($"{fridgeToTake} is null");
            }
            if (quantity > fridgeToTake.Quantity)
            {
                _logger.LogInfo($"Fridge: {fridge} contains less quantity of product than you want to take. Will take as much as there is and will remain 0");
            }

            fridgeToTake.Quantity -= quantity;
            if (fridgeToTake.Quantity < 0)
                fridgeToTake.Quantity = 0;

            await _repository.SaveAsync();

            return fridgeToTake.Quantity;
        }
    }
}
