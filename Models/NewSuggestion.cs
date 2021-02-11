using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment42.Models
{
    public class NewSuggestion
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public string Restraunt_Name { get; set; }
        [Required]
        public string Favorite_Dish { get; set; }

        [Required]
        [DataType(DataType.PhoneNumber)]
        public string Phone { get; set; }
    }
}
