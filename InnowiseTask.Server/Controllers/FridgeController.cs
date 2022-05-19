using AutoMapper;
using InnowiseTask.Server.Data.Models;
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
    [Route("api/fridges")]
    [ApiController]
    public class FridgeController : ControllerBase
    {
        private readonly IRepositoryManager _repository;
        private readonly IFridgeManager _ridgeManager;
        private readonly ILoggerManager _logger;
        private readonly IMapper _mapper;

        public FridgeController(IRepositoryManager repository, ILoggerManager logger, IMapper mapper, IFridgeManager ridgeManager)
        {
            _repository = repository;
            _logger = logger;
            _mapper = mapper;
            _ridgeManager = ridgeManager;
        }

        [HttpGet]
        public async Task<IActionResult> GetFridges()
        {
            var m1 = new List<DateTime>() { new DateTime(2021, 01, 01), new DateTime(2021, 02, 01), new DateTime(2021, 03, 01), };
            var m2 = new List<DateTime>() { new DateTime(2021, 01, 13) };
             _ridgeManager.LehinaZadacha(m1, m2);

            var fridges = await _repository.Fridge.GetAllFridgesAsync();

            var fridgesDto = _mapper.Map<IEnumerable<FridgeDto>>(fridges);

            return Ok(fridgesDto);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetFridge(Guid id)
        {
            var fridge =  await _repository.Fridge.GetFridgeAsync(id);

            if(fridge == null)
            {
                _logger.LogInfo($"Fridge with id: {id} doesnt exist in the database.");
                return NotFound();
            }
            else
            {
                var fridgeDto = _mapper.Map<FridgeDto>(fridge);
                return Ok(fridgeDto);
            }
        }
    }
}
