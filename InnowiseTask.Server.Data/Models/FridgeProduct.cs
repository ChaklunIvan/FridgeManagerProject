using InnowiseTask.Server.Data.Models.Base;
using System;

namespace InnowiseTask.Server.Data.Models
{
    public class FridgeProduct : BaseModel
    {
        public Fridge Fridge { get; set; }
        public Guid FridgeId { get; set; }

        public Product Product { get; set; }
        public Guid ProductId { get; set; }

        public int Quantity { get; set; }

    }
}
