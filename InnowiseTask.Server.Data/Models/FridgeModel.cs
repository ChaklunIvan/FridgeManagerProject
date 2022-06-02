using InnowiseTask.Server.Data.Models.Base;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace InnowiseTask.Server.Data.Models
{
    public class FridgeModel : BaseModel
    {
        [Required(ErrorMessage = "FridgeModel name is a required field.")]
        [MaxLength(50, ErrorMessage = "Maximum length for the Name is 50 characters")]
        public string Name { get; set; }
        public int? Year { get; set; }
        public IList<Fridge> Fridges { get; set; }
    }
}
