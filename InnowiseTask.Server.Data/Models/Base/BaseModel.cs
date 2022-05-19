using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Reflection;

namespace InnowiseTask.Server.Data.Models.Base
{
    public abstract class BaseModel
    {
        public Guid Id { get; set; }
    }
}
