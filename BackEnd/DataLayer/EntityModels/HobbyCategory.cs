using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DataLayer.EntityModels
{
    public class HobbyCategory: Entity, IEntity
    {
        [Required]
        public string Name { get; set; }
        public DateTime? ModifiedDate { get; set; }
    }
}
