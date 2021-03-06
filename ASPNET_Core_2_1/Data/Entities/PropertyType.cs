﻿using System.ComponentModel.DataAnnotations;

namespace ASPNET_Core_2_1.Data.Entities
{
    public class PropertyType
    {
        public int Id { get; set; }

        [Display(Name = "Property Type")]
        [MaxLength(50, ErrorMessage = "The {0} field can not have more than {1} characters.")]
        [Required(ErrorMessage = "The field {0} is mandatory.")]
        public string Name { get; set; }
    }

}
