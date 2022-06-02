using InnowiseTask.Server.Data.Models.Base;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace InnowiseTask.Server.Data.Models
{
    public class Product : BaseModel
    {
        [Required(ErrorMessage = "Product name is a required field.")]
        [MaxLength(60, ErrorMessage = "Maximum length for the Name is 50 characters")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Product DefaultQuantity is a required field.")]
        public int? DefaultQuantity { get; set; }
        public string Image { get; set; }
        public IList<FridgeProduct> FridgeProducts { get; set; }
    }
}
