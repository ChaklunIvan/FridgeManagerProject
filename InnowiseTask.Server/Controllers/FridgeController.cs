using AutoMapper;
using InnowiseTask.Server.Data.Models;
using InnowiseTask.Server.Data.Models.Dto;
using InnowiseTask.Server.Data.Repositories.Interfaces;
using InnowiseTask.Server.Extensions;
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
        private readonly IFridgeService _fridgeManager;
        private readonly ILoggerManager _logger;
        private readonly IMapper _mapper;

        public FridgeController(IRepositoryManager repository, ILoggerManager logger, IMapper mapper, IFridgeService fridgeManager)
        {
            _repository = repository;
            _logger = logger;
            _mapper = mapper;
            _fridgeManager = fridgeManager;
        }

        [HttpGet]
        public async Task<IActionResult> GetFridges()
        {
            var fridges = await _repository.Fridge.GetAllFridgesAsync();

            if(fridges == null)
            {
                _logger.LogInfo($"Fridges is empty: {fridges} or something went wrong");
                return NotFound();
            }

            var fridgesDto = _mapper.Map<IEnumerable<FridgeDto>>(fridges);

            return Ok(fridgesDto);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateFridge(Guid id, [FromBody] FridgeToUpdateDto fridge)
        {
            if (fridge == null)
            { 
                _logger.LogError($"FridgeToUpdateDto object: {fridge} sent from client is null.");
                return BadRequest("FridgeToUpdateDto object is null");
            }

            var fridgeToUpdate = await _repository.Fridge.GetFridgeAsync(id);
            if (fridgeToUpdate == null)
            {
                _logger.LogInfo($"Fridge with id: {id} doesnt exist in database");
                return NotFound();
            }

            fridge.Id = fridgeToUpdate.Id;
            var updatedFridge = _mapper.Map(fridge, fridgeToUpdate);
            await _repository.SaveAsync();

            return Ok(updatedFridge);
        }
    }
}
