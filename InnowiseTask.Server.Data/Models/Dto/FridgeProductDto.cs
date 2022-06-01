using InnowiseTask.Server.Data.Models.Base;

namespace InnowiseTask.Server.Data.Models.Dto
{
    public class FridgeProductDto : BaseModel
    {
        public string ProductName { get; set; }
        public string FridgeName { get; set; }
        public int Quantity { get; set; }
    }
}
