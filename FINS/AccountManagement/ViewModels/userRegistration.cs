using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using AccountManagement.Models;
using Microsoft.AspNetCore.Mvc;


/*
    Author: Nick Dechativong
    Class: CIS 234A
    Objective: This view model is used to encapsulate the registration data in the presentation layer
*/



namespace AccountManagement.ViewModels
{
    // View Model for manage user registration data
    public class userRegistration
    {

        [Required]
        [Display(Name = "Username")]
        [Remote(action: "VerifyUsername", controller: "Account")]
        public string userName { get; set; }

        [Required]
        [Display(Name = "Password")]
        [StringLength(20, ErrorMessage = "The {0} must include between {2} to {1} characters.", MinimumLength = 9)]
        [RegularExpression(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[$@$!%*?&])[A-Za-z\d$@$!%*?&]{9,20}", ErrorMessage = "Please enter a valid password.")]
        [DataType(DataType.Password)]
        public string password { get; set; }

        [Required]
        [Display(Name = "Full Name")]
        public string fullName { get; set; }

        [Required]
        [Display(Name = "Email Address")]
        [EmailAddress]
        [RegularExpression(@"^([a-zA-Z0-9_\-\.]+)@([a-zA-Z0-9_\-\.]+)\.([a-zA-Z]{2,5})$", ErrorMessage = "Please enter a valid email address.")]
        [Remote(action: "VerifyEmail", controller: "Account")]
        public string emailAddress { get; set; }

        [Required]
        [Display(Name = "Confirm Password")]
        [DataType(DataType.Password)]
        [Compare("password", ErrorMessage = "The password and confirmation password do not match.")]
        public string confirmPassword { get; set; }

        [Display(Name = "Phone Number")]
        [Phone]
        [RegularExpression(@"^[0-9]{3}[-]?[0-9]{3}[-]?[0-9]{4}$", ErrorMessage = "Please enter a valid phone number.")]
        public string phoneNumber { get; set; }

    }
}
