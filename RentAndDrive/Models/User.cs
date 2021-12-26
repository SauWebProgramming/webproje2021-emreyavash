using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RentAndDrive.Models
{
    public class User
    {
        [Key]
        public int UserId { get; set; }
        
        [Required(ErrorMessage = "{0} is required")]
        [DisplayName("UserName")]
        [StringLength(20, ErrorMessage = "İsminiz uzunluğu 20 karakteri geçemez.")]
        public string UserName { get; set; }
        
        [Required(ErrorMessage = "{0} is required")]
        [DisplayName("UserSurname")]

        public string UserSurname { get; set; }

        [Required(ErrorMessage = "{0} is required")]
        [DisplayName("UserEmail")]
        public string Email { get; set; }

        [Required(ErrorMessage = "{0} is required")]
        [DisplayName("UserPassword")]
        [StringLength(20, ErrorMessage = "Şifreniz  8 ve 20 karakter arasında olabilir.", MinimumLength = 8)]
        public string Password { get; set; }

        [Required(ErrorMessage = "{0} is required")]
        [DisplayName("UserBirthDay")]
        public string BirthDay { get; set; }


        [Required(ErrorMessage = "{0} is required")]
        [DisplayName("UserPhone")]
        [StringLength(10, ErrorMessage = "Başında sıfır olmadan numaranızı doğru giriniz.", MinimumLength = 10)]
        public string Phone { get; set; }
        public string Role { get; set; }
    }
}
