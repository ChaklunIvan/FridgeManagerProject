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
    public class FridgeManager : IFridgeManager
    {
        private readonly IRepositoryManager _repository;
        private readonly ILoggerManager _logger;

        public FridgeManager(IRepositoryManager repository, ILoggerManager logger)
        {
            _repository = repository;
            _logger = logger;
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
            var fridgeProductForRemove = fridgeProducts.Where(f => f.FridgeId == fridgeId).FirstOrDefault(p => p.ProductId == productId);
            _repository.FridgeProduct.RemoveFridgeProduct(fridgeProductForRemove);

            await _repository.SaveAsync();
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
        }










        public void LehinaZadacha(List<DateTime> dateTimes1, List<DateTime> dateTimes2)
        {
            foreach(var date in dateTimes2)
            {
                dateTimes1.Add(date);
            }
            dateTimes1.OrderBy(d => d.Day);
        }

    }
}
