using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AccountManagement.ViewModels
{
    public class userLogin
    {
        [Required]
        [Display(Name = "Username")]
        public string userName { get; set; }

        // TODO: Add password hashing function
        [Required]
        [Display(Name = "Password")]
        [DataType(DataType.Password)]
        public string password { get; set; }
    }
}
