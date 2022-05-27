using InnowiseTask.Server.Data.Models;
using InnowiseTask.Server.Data.Repositories.Interfaces;
using InnowiseTask.Server.Services;
using InnowiseTask.Server.Services.Interfaces;
using Moq;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xunit;

namespace InnowiseTask.Server.Test
{/// <summary>
/// *Postman was used to test deleting
/// </summary>
    public class FridgeServiceTest
    {
        private readonly FridgeService _serviceUnderTest;
        private readonly Mock<IRepositoryManager> _repositoryManagerMock = new();
        private readonly Mock<ILoggerManager> _logger = new();

        public FridgeServiceTest()
        {
            _serviceUnderTest = new FridgeService(_repositoryManagerMock.Object, _logger.Object);
        }

        [Fact]
        public async Task AddProducts_Return_AddedProduct()
        {
            //Arrange
            var productId = new Guid("F428D3B7-D5AE-4ADA-8944-1D4A2E433238");
            var fridgeId = new Guid("4C086779-212E-4864-BE35-6749F4EE47CD");
            _repositoryManagerMock.Setup(option => option.Product.GetProductsAsync(productId)).ReturnsAsync(TestConfiguration.Products.FirstOrDefault(p => p.Id == productId));
            _repositoryManagerMock.Setup(option => option.Fridge.GetFridgeAsync(fridgeId)).ReturnsAsync(TestConfiguration.Fridges.FirstOrDefault(f => f.Id == fridgeId));
            _repositoryManagerMock.Setup(option => option.FridgeProduct.GetAllFridgeProductsAsync()).ReturnsAsync(TestConfiguration.FridgeProducts);
            var expected = new FridgeProduct
            {
                FridgeId = fridgeId,
                ProductId = productId,
            };

            //Act
            var actual = await _serviceUnderTest.AddProducts(productId, fridgeId);

            //Assert
            Assert.Equal(expected.FridgeId, actual.FridgeId);
            Assert.Equal(expected.ProductId, actual.ProductId);
        }

        [Fact]
        public async Task AddProducts_Return_ProductWithPlusQuantity()
        {
            //Arrange
            var productId = new Guid("2888DC78-AE37-4A63-A09A-B3B356B47DD4");
            var fridgeId = new Guid("A75C18D9-A2B6-42CD-94D7-CC73F5AFBF44");
            _repositoryManagerMock.Setup(option => option.Product.GetProductsAsync(productId)).ReturnsAsync(TestConfiguration.Products.FirstOrDefault(p => p.Id == productId));
            _repositoryManagerMock.Setup(option => option.Fridge.GetFridgeAsync(fridgeId)).ReturnsAsync(TestConfiguration.Fridges.FirstOrDefault(f => f.Id == fridgeId));
            _repositoryManagerMock.Setup(option => option.FridgeProduct.GetAllFridgeProductsAsync()).ReturnsAsync(TestConfiguration.FridgeProducts);
            var expected = 5;

            //Act
            var actual = await _serviceUnderTest.AddProducts(productId, fridgeId);

            //Assert
            Assert.Equal(expected, actual.Quantity);
        }

        [Fact]
        public async Task AddProducts_Return_AddeListOfProducts()
        {
            //Arrange
            var products = new List<Guid>() { new Guid("F428D3B7-D5AE-4ADA-8944-1D4A2E433238"), new Guid("8F4DDA36-4BE7-4EBB-9A09-51448DE3EC92"), new Guid("8186EC59-231A-4A94-A589-584E48EE567A") };
            var fridgeId = new Guid("4C086779-212E-4864-BE35-6749F4EE47CD");
            var returnProducts = new List<Product>() { TestConfiguration.Products[7], TestConfiguration.Products[1], TestConfiguration.Products[3] };
            _repositoryManagerMock.Setup(option => option.Product.GetProductsAsync(products)).ReturnsAsync(returnProducts);
            _repositoryManagerMock.Setup(option => option.Fridge.GetFridgeAsync(fridgeId)).ReturnsAsync(TestConfiguration.Fridges.FirstOrDefault(f => f.Id == fridgeId));
            _repositoryManagerMock.Setup(option => option.FridgeProduct.GetAllFridgeProductsAsync()).ReturnsAsync(TestConfiguration.FridgeProducts);
            var expected = new List<FridgeProduct>()
            {
                new FridgeProduct {FridgeId = new Guid("4C086779-212E-4864-BE35-6749F4EE47CD"), ProductId = new Guid("F428D3B7-D5AE-4ADA-8944-1D4A2E433238") },
                new FridgeProduct {FridgeId = new Guid("4C086779-212E-4864-BE35-6749F4EE47CD"), ProductId = new Guid("8F4DDA36-4BE7-4EBB-9A09-51448DE3EC92") },
                new FridgeProduct {FridgeId = new Guid("4C086779-212E-4864-BE35-6749F4EE47CD"), ProductId = new Guid("8186EC59-231A-4A94-A589-584E48EE567A") }
            };

            //Act
            var actual = await _serviceUnderTest.AddProducts(products, fridgeId);

            //Assert
            Assert.Equal(expected.Select(s => s.ProductId), actual.Select(s => s.ProductId));
            Assert.Equal(expected.Select(s => s.FridgeId), actual.Select(s => s.FridgeId));
        }

        [Fact]
        public async Task AddProducts_Return_ListOfProductsPlusQuantity()
        {
            //Arrange
            var products = new List<Guid>() { new Guid("24D601BC-965F-457F-AE2E-5BF34AFCBA8B"), new Guid("E5F23484-9191-4101-9CED-60C771B367BF"), new Guid("3CD8E973-320D-410D-889A-8522767B6549") };
            var fridgeId = new Guid("356C09B5-D03B-4D86-AABA-C59E6937C0CF");
            var returnProducts = new List<Product>() { TestConfiguration.Products[4], TestConfiguration.Products[0], TestConfiguration.Products[2] };
            _repositoryManagerMock.Setup(option => option.Product.GetProductsAsync(products)).ReturnsAsync(returnProducts);
            _repositoryManagerMock.Setup(option => option.Fridge.GetFridgeAsync(fridgeId)).ReturnsAsync(TestConfiguration.Fridges.FirstOrDefault(f => f.Id == fridgeId));
            _repositoryManagerMock.Setup(option => option.FridgeProduct.GetAllFridgeProductsAsync()).ReturnsAsync(TestConfiguration.FridgeProducts);
            var expected = new List<int>() { 2, 4, 6 };

            //Act
            var actual = await _serviceUnderTest.AddProducts(products, fridgeId);

            //Assert
            Assert.Equal(expected, actual.Select(s => s.Quantity));
        }

        [Fact]
        public async Task AddProducts_Return_AddedListOfProducts_AddedQuantity()
        {
            //Arrange
            var products = new List<Guid>() { new Guid("24D601BC-965F-457F-AE2E-5BF34AFCBA8B"), new Guid("8F4DDA36-4BE7-4EBB-9A09-51448DE3EC92"), new Guid("8186EC59-231A-4A94-A589-584E48EE567A") };
            var fridgeId = new Guid("356C09B5-D03B-4D86-AABA-C59E6937C0CF");
            var returnProducts = new List<Product>() { TestConfiguration.Products[4], TestConfiguration.Products[1], TestConfiguration.Products[3] };
            _repositoryManagerMock.Setup(option => option.Product.GetProductsAsync(products)).ReturnsAsync(returnProducts);
            _repositoryManagerMock.Setup(option => option.Fridge.GetFridgeAsync(fridgeId)).ReturnsAsync(TestConfiguration.Fridges.FirstOrDefault(f => f.Id == fridgeId));
            _repositoryManagerMock.Setup(option => option.FridgeProduct.GetAllFridgeProductsAsync()).ReturnsAsync(TestConfiguration.FridgeProducts);
            var expectedProducts = new List<FridgeProduct>() 
            {
                new FridgeProduct {FridgeId = new Guid("356C09B5-D03B-4D86-AABA-C59E6937C0CF"), ProductId = new Guid("24D601BC-965F-457F-AE2E-5BF34AFCBA8B") },
                new FridgeProduct {FridgeId = new Guid("356C09B5-D03B-4D86-AABA-C59E6937C0CF"), ProductId = new Guid("8F4DDA36-4BE7-4EBB-9A09-51448DE3EC92") },
                new FridgeProduct {FridgeId = new Guid("356C09B5-D03B-4D86-AABA-C59E6937C0CF"), ProductId = new Guid("8186EC59-231A-4A94-A589-584E48EE567A") }
            };
            var expectedQuantity = new List<int> { 2, 3, 1};

            //Act
            var actual = await _serviceUnderTest.AddProducts(products, fridgeId);

            //Assert
            Assert.Equal(expectedQuantity, actual.Select(s => s.Quantity));
            Assert.Equal(expectedProducts.Select(p => p.ProductId), actual.Select(p => p.ProductId));
            Assert.Equal(expectedProducts.Select(f => f.FridgeId), actual.Select(f => f.FridgeId));
        }

        [Fact]
        public async Task TakeProduct_ReduceQuantity()
        {
            //Arrange
            var product = new Guid("E5F23484-9191-4101-9CED-60C771B367BF");
            var fridge = new Guid("356C09B5-D03B-4D86-AABA-C59E6937C0CF");
            int quantity = 3;
            _repositoryManagerMock.Setup(option => option.Product.GetProductsAsync(product)).ReturnsAsync(TestConfiguration.Products.FirstOrDefault(p => p.Id == product));
            _repositoryManagerMock.Setup(option => option.Fridge.GetFridgeAsync(fridge)).ReturnsAsync(TestConfiguration.Fridges.FirstOrDefault(f => f.Id == fridge));
            _repositoryManagerMock.Setup(option => option.FridgeProduct.GetAllFridgeProductsAsync()).ReturnsAsync(TestConfiguration.FridgeProducts);
            _logger.Setup(option => option.LogInfo($"Fridge: {fridge} contains less quantity of product than you want to take. Will take as much as there is and will remain 0"));
            int expectedQuantity = 0;

            //Act
            var actual = await _serviceUnderTest.TakeProduct(product, fridge, quantity);

            //Assert
            Assert.Equal(actual, expectedQuantity);
        }
    }
}