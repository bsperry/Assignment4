using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment42.Models
{
    public class Restraunt
    {
        public Restraunt(int rank)
        {
            Rank = rank;
        }
        [Required]
        public int Rank { get; set; }
        [Required]
        public string Restraunt_Name { get; set; }
        public string? Favorite_Dish { get; set; } = "It's all tasty!";
        [Required]
        public string Address { get; set; }

        [DataType(DataType.PhoneNumber)]
        public string Phone { get; set; }
        public string? Website { get; set; } = "Coming soon";

        //make a list to enumerate through with prepopulated values
        public static Restraunt[] GetRestraunts()
        {
            Restraunt r1 = new Restraunt(1)
            {
                Restraunt_Name = "La Dolce Vita Ristorante Italiano",
                Favorite_Dish = "Chef's Special",
                Address = "61 N 100 E, Provo, UT",
                Phone = "801-373-8482",
                Website = "http://www.ladolcevitaprovo.com/"
            };

            Restraunt r2 = new Restraunt(2)
            {
                Restraunt_Name = "Asa Ramen",
                Favorite_Dish = "Tonkotsu Ramen",
                Address = "1120 State Street, Orem, UT",
                Phone = "801-842-1898",
                Website = "https://www.grubhub.com/restaurant/asa-ramen-1120-state-street-orem/1511441"
            };
            Restraunt r3 = new Restraunt(3)
            {
                Restraunt_Name = "Chick-fil-A",
                Favorite_Dish = "Chicken Nuggets",
                Address = "484 Bulldog Blvd, Provo, Utah",
                Phone = "801-374-26972",
                Website = "https://www.chick-fil-a.com/locations/ut/cougar-state"
            };
            Restraunt r4 = new Restraunt(4)
            {
                Restraunt_Name = "Costa Vida",
                Favorite_Dish = "Pork Salad",
                Address = "1200 N University Ave, Provo, UT",
                Phone = "801-373-1876",
                Website = "https://www.costavida.com/locations?gclid=Cj0KCQiApY6BBhCsARIsAOI_GjZ2tXWd_rwWCCPYE0xzucFJ924fjOYsyfl-o9jnQyprjOhpbNo3HqkaAuE9EALw_wcB"
            };
            Restraunt r5 = new Restraunt(5)
            {
                Restraunt_Name = "Bombay House",
                Favorite_Dish = "Chicken Coconut Kurma",
                Address = "463 N University Ave, Provo, UT",
                Phone = "801-373-6677",
                Website = "https://bombayhouse.com/"
            };

            return new Restraunt[] { r1, r2, r3, r4, r5 };

        }
    }
}

