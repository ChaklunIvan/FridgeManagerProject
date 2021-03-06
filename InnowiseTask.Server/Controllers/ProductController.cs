using AutoMapper;
using InnowiseTask.Server.Data.Models;
using InnowiseTask.Server.Data.Models.Dto;
using InnowiseTask.Server.Data.Repositories.Interfaces;
using InnowiseTask.Server.Services.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;

namespace InnowiseTask.Server.Controllers
{
    [Route("api/fridges/{fridgeId}/products")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IRepositoryManager _repository;
        private readonly IFridgeService _fridgeManager;
        private readonly IMapper _mapper;

        public ProductController(IRepositoryManager repository, IMapper mapper, IFridgeService fridgeManager)
        {
            _repository = repository;
            _mapper = mapper;
            _fridgeManager = fridgeManager;
        }

        [HttpGet]
        public async Task<IActionResult> GetProductsForFridge(Guid fridgeId)
        {
            var products = await _fridgeManager.ProductsInFridge(fridgeId);
            var fridgeProducts = await _repository.FridgeProduct.GetAllFridgeProductsAsync();
            fridgeProducts.Where(f => f.FridgeId == fridgeId);

            var productsDto = _mapper.Map<IEnumerable<ProductDto>>(products);
            foreach (var product in productsDto)
            {
                var quantity = fridgeProducts.FirstOrDefault(p => p.ProductId == product.Id).Quantity;
                product.Quantity = quantity;
            }

            return Ok(productsDto);
        }

        [HttpPost("{id}"), Authorize(Roles = "Manager, Administrator") ]
        public async Task<IActionResult> AddProductsToFridge(Guid fridgeId, Guid id)
        {
            var addedProducts = await _fridgeManager.AddProducts(id, fridgeId);

            var fridgeProductsDto = _mapper.Map<FridgeProductDto>(addedProducts);

            return Ok(fridgeProductsDto);
        }

        [HttpPost, Authorize(Roles = "Manager, Administrator")]
        public async Task<IActionResult> AddProductsToFridge(Guid fridgeId, [FromBody] JsonElement productsId)
        {
            var productsGuid = JsonConvert.DeserializeObject<List<Guid>>(productsId.GetProperty($"productsId").ToString());

            var addedProducts = await _fridgeManager.AddProducts(productsGuid, fridgeId);

            var fridgeProductsDto = _mapper.Map<IEnumerable<FridgeProductDto>>(addedProducts);

            return Ok(fridgeProductsDto);
        }

        [HttpDelete("{id}"), Authorize(Roles = "Manager, Administrator")]
        public async Task<IActionResult> RemoveProductsFromFridge(Guid fridgeId, Guid id)
        {
            await _fridgeManager.RemoveProducts(id, fridgeId);

            return Ok();
        }

        [HttpDelete, Authorize(Roles = "Manager, Administrator")]
        public async Task<IActionResult> RemoveProductsFromFridge(Guid fridgeId, [FromBody] JsonElement productsId)
        {
            var productsGuid = JsonConvert.DeserializeObject<List<Guid>>(productsId.GetProperty($"productsId").ToString());

            await _fridgeManager.RemoveProducts(productsGuid, fridgeId);

            return Ok();
        }

        [HttpDelete("{id}/{quantity}"), Authorize(Roles = "Manager, Administrator, User")]
        public async Task<IActionResult> TakeProductFromFridge(Guid fridgeId, Guid id, int quantity)
        {
            var actualQuantity = await _fridgeManager.TakeProduct(id, fridgeId, quantity);

            return Ok(actualQuantity);
        }
    }
}
