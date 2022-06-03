using AutoMapper;
using InnowiseTask.Server.Data.Models;
using InnowiseTask.Server.Data.Models.Dto;
using InnowiseTask.Server.Services.Interfaces;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System.Threading.Tasks;

namespace InnowiseTask.Server.Controllers
{
    [Route("api/authentication")]
    [ApiController]
    public class AuthenticationController : ControllerBase
    {
        private readonly ILoggerManager _logger;
        private readonly IMapper _mapper;
        private readonly UserManager<User> _userManager;
        private readonly IAuthenticationManager _authenticationManager;
        public AuthenticationController(ILoggerManager logger, IMapper mapper, UserManager<User> userManager, IAuthenticationManager authenticationManager)
        {
            _logger = logger;
            _mapper = mapper;
            _userManager = userManager;
            _authenticationManager = authenticationManager;
        }

        [HttpPost("login")]
        public async Task<IActionResult> Authenticate([FromBody] UserForAuthenticationDto userForAuthentication)
        {
            if (userForAuthentication == null)
            {
                _logger.LogError($"UserForAuthenticationDto object: {userForAuthentication} sent from client is null.");
                return BadRequest("UserForAuthenticationDto object is null");
            }

            if(!await _authenticationManager.ValidateUser(userForAuthentication))
            {
                _logger.LogWarning($"{nameof(Authenticate)}: Authentication failed. Wrong user name or password");
                return Unauthorized();
            }

            return Ok(new { Token = await _authenticationManager.CreateToken() });
        }

        [HttpPost]
        public async Task<IActionResult> RegisterUser([FromBody] UserForRegistrationDto userForRegistration)
        {
            if(userForRegistration == null)
            {
                _logger.LogError($"UserForRegistrationDto object: {userForRegistration} sent from client is null.");
                return BadRequest("UserForRegistrationDto object is null");
            }

            var user = _mapper.Map<User>(userForRegistration);
            var result = await _userManager.CreateAsync(user, userForRegistration.Password);
            if (!result.Succeeded)
            {
                foreach (var error in result.Errors)
                {
                    ModelState.TryAddModelError(error.Code, error.Description);
                    _logger.LogError(error.Code + "-" + error.Description);
                }
                return BadRequest(ModelState);
            }

            await _userManager.AddToRolesAsync(user, userForRegistration.Roles);

            return StatusCode(201);
        }
    }
}
