using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RentAndDrive.Models
{
    public class Contact
    {
        [Key]
        public int CustomerId { get; set; }
        public String Name { get; set; }
        public String Surname { get; set; }
        public String Email { get; set; }
        public String Message { get; set; }
    }
}
