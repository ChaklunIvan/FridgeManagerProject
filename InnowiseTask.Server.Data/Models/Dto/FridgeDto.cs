using InnowiseTask.Server.Data.Models.Base;

namespace InnowiseTask.Server.Data.Models.Dto
{
    public class FridgeDto : BaseModel
    {
        public string FullName { get; set; }
        public string FridgeModelId { get; set; }
    }
}
