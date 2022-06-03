using InnowiseTask.Server.Data.Models.Dto;
using System.Threading.Tasks;

namespace InnowiseTask.Server.Services.Interfaces
{
    public interface IAuthenticationManager
    {
        Task<bool> ValidateUser(UserForAuthenticationDto userForAuthentication);
        Task<string> CreateToken();
    }
}
