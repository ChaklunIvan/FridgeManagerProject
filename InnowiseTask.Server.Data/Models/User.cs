using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace InnowiseTask.Server.Data.Models
{
    public class User : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
