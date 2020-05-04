/*
    Author:         Nick Dechativong
    Created Date:   04/23/2020
    Class:          CIS 234A
    Objective:      This view model is used to encapsulate the registration data and validation from the presentation layer
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using AccountManagement.Models;
using Microsoft.AspNetCore.Mvc;


namespace AccountManagement.ViewModels
{
    // View Model for manage user registration data
    public class userRegistration
    { 
        [Required]
        [Display(Name = "Username")]
        [Remote(action: "VerifyUsername", controller: "Account")]
        public string userName { get; set; }

        // Use RegEx to check for 9-25 characters, including 1 uppercase letter, 1 lowercase letter, 1 number and 1 special character
        [Required]
        [Display(Name = "Password")]
        [StringLength(25, ErrorMessage = "The {0} must include between {2} to {1} characters.", MinimumLength = 9)]
        [RegularExpression(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[$@$!%*?&^_])[A-Za-z\d$@$!%*?&^_]{9,25}", ErrorMessage = "Please enter a valid password.")]
        [DataType(DataType.Password)]
        public string password { get; set; }

        [Required]
        [Display(Name = "Full Name")]
        public string fullName { get; set; }

        // Use RegEx to check for valid email address including the use of @ and . characters
        [Required]
        [Display(Name = "Email Address")]
        [EmailAddress]
        [RegularExpression(@"^([a-zA-Z0-9_\-\.]+)@([a-zA-Z0-9_\-\.]+)\.([a-zA-Z]{2,5})$", ErrorMessage = "Please enter a valid email address.")]
        [Remote(action: "VerifyEmail", controller: "Account")]
        public string emailAddress { get; set; }

        // Use [Compare] to validate matching password
        [Required]
        [Display(Name = "Confirm Password")]
        [DataType(DataType.Password)]
        [Compare("password", ErrorMessage = "The password and confirmation password do not match.")]
        public string confirmPassword { get; set; }

        // Use RegEx to check valid 10-digit phone number, - is optional
        [Display(Name = "Phone Number")]
        [Phone]
        [StringLength(12, ErrorMessage = "The {0} must include between {2} to {1} characters.", MinimumLength = 10)]
        [RegularExpression(@"^[0-9]{3}[-]?[0-9]{3}[-]?[0-9]{4}$", ErrorMessage = "Please enter a valid phone number.")]
        public string phoneNumber { get; set; }
    }
}
