using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RentAndDrive.Models
{
    public class Car
    {
        [Key]
        public int CarId { get; set; }
        public string CarName { get; set; }
        public string Price { get; set; }
        public string Km { get; set; }
        public string Year { get; set; }
        public string Model { get; set; }
        public string Vites { get; set; }
        public string Yakit { get; set; }
        public string ImageUrl { get; set; }
        
        public int CategoryId { get; set; }

        public virtual Category Category { get; set; }
    }
}
