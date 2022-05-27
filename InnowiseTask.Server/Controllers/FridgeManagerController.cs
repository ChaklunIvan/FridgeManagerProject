using AutoMapper;
using InnowiseTask.Server.Data.Models.Dto;
using InnowiseTask.Server.Data.Repositories.Interfaces;
using InnowiseTask.Server.Services.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InnowiseTask.Server.Controllers
{
    [Route("api/fridgemanager")]
    [ApiController]
    public class FridgeManagerController : ControllerBase
    {
        private readonly IRepositoryManager _repository;
        private readonly IFridgeService _ridgeManager;
        private readonly ILoggerManager _logger;
        private readonly IMapper _mapper;

        public FridgeManagerController(IRepositoryManager repository, ILoggerManager logger, IMapper mapper, IFridgeService ridgeManager)
        {
            _repository = repository;
            _logger = logger;
            _mapper = mapper;
            _ridgeManager = ridgeManager;
        }

        [HttpGet("fridges")]
        public async Task<IActionResult> GetFridges()
        {
            var fridges = await _repository.Fridge.GetAllFridgesAsync();

            var fridgesDto = _mapper.Map<IEnumerable<FridgeDto>>(fridges);

            return Ok(fridgesDto);
        }

        [HttpGet("fridges/{id}")]
        public async Task<IActionResult> GetProductsFromFridge(Guid id)
        {
            var products = await _ridgeManager.ProductsInFridge(id);

            var productsDto = _mapper.Map<IEnumerable<ProductDto>>(products);
            return Ok(productsDto);
        }
    }
}
