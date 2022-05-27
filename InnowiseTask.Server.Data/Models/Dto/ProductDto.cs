using InnowiseTask.Server.Data.Models.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InnowiseTask.Server.Data.Models.Dto
{
    public class ProductDto : BaseModel
    {
        public string Name { get; set; }
        public int Quantity { get; set; }
    }
}
