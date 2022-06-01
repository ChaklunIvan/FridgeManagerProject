using InnowiseTask.Server.Data.Models.Base;
using System;

namespace InnowiseTask.Server.Data.Models.Dto
{
    public class FridgeToUpdateDto : BaseModel
    {
        public string Name { get; set; }
        public string OwnerName { get; set; }
        public Guid FridgeModelId { get; set; }
    }
}
