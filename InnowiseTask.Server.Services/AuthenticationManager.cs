using InnowiseTask.Server.Data.Models;
using InnowiseTask.Server.Data.Models.Dto;
using InnowiseTask.Server.Services.Interfaces;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace InnowiseTask.Server.Services
{
    public class AuthenticationManager : IAuthenticationManager
    {
        private readonly UserManager<User> _userManager;
        private readonly IConfiguration _configuration;
        private readonly ILoggerManager _logger;
        private User _user;
        public AuthenticationManager(UserManager<User> userManager, IConfiguration configuration)
        {
            _userManager = userManager;
            _configuration = configuration;
        }

        public async Task<bool> ValidateUser(UserForAuthenticationDto userForAuthentication)
        {
            _user = await _userManager.FindByNameAsync(userForAuthentication.UserName);
            if (_user == null)
            {
                _logger.LogError($"User with name: {userForAuthentication.UserName} doesnt exist");
                throw new NullReferenceException($"Object: {_user} is null");
            }

            var result = await _userManager.CheckPasswordAsync(_user, userForAuthentication.Password);
            return result;
        }

        public async Task<string> CreateToken()
        {
            var signingCredentials = GetSigningCredentials();
            var claims = await GetClaims();
            var tokenOptions = GenerateTokenOptions(signingCredentials, claims);

            return new JwtSecurityTokenHandler().WriteToken(tokenOptions);
        }

        private SigningCredentials GetSigningCredentials()
        {
            var key = Encoding.UTF8.GetBytes(Environment.GetEnvironmentVariable("SECRET"));
            if (key == null)
            {
                _logger.LogError($"key: {key} is null. Something went wrong");
                throw new NullReferenceException($"Object: {key} is null");
            }
            var secret = new SymmetricSecurityKey(key);

            return new SigningCredentials(secret, SecurityAlgorithms.HmacSha256);
        }
        private async Task<List<Claim>> GetClaims()
        {
            var claims = new List<Claim>
            {
                new Claim(ClaimTypes.Name, _user.UserName)
            };

            var roles = await _userManager.GetRolesAsync(_user);
            if (roles == null)
            {
                _logger.LogInfo($"User with name: {_user.UserName}, dont have any roles {roles}");
            }
            else
            {
                foreach (var role in roles)
                {
                    claims.Add(new Claim(ClaimTypes.Role, role));
                }
            }

            return claims;
        }

        private JwtSecurityToken GenerateTokenOptions(SigningCredentials signingCredentials, List<Claim> claims)
        {
            var jwtSettings = _configuration.GetSection("JwtSettings");
            if (jwtSettings == null)
            {
                _logger.LogError($"Jwt settings: {jwtSettings} is null. Something went wrong");
                throw new NullReferenceException($"Object: {jwtSettings} is null");
            }

            var tokenOptions = new JwtSecurityToken
                (
                issuer: jwtSettings.GetSection("validIssuer").Value,
                audience: jwtSettings.GetSection("validAudience").Value,
                claims: claims,
                expires: DateTime.Now.AddMinutes(Convert.ToDouble(jwtSettings.GetSection("expires").Value)),
                signingCredentials: signingCredentials
                );
            if (tokenOptions == null)
            {
                _logger.LogError($"Token options: {tokenOptions} is null. Something went wrong");
                throw new NullReferenceException($"Object: {tokenOptions} is null");
            }

            return tokenOptions;
        }
    }
}
