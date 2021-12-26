using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RentAndDrive.Models
{
    public class Category
    {
        [Key]
        public int CategoryId { get; set; }
        [Required(ErrorMessage = "Kategori Adını Boş Bırakmayınız.")]
        public string CategoryName { get; set; }
        public bool Status { get; set; }
    }
}
