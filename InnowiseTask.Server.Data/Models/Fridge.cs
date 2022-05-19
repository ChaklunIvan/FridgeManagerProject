using InnowiseTask.Server.Data.Models.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace InnowiseTask.Server.Data.Models
{
    public class Fridge : BaseModel
    {
        [Required(ErrorMessage ="Fridge name is a required field.")]
        [MaxLength(50, ErrorMessage ="Maximum length for the Name is 50 characters")]
        public string Name { get; set; }
        [MaxLength(60, ErrorMessage = "Maximum length for the OwnerName is 50 characters")]
        public string OwnerName { get; set; }

        public Guid FridgeModelId { get; set; }
        public FridgeModel FridgeModel { get; set; }

        public IList<FridgeProduct> FridgeProducts { get; set; }
         
    }
}
