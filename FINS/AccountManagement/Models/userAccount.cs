﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


/*
    Author: Nick Dechativong
    Class: CIS 234A
    Objective: This model is used to encapsulate the user account data and some validation logics
*/

namespace AccountManagement.Models
{
    // Model for manage user account entity
    [Table("user_account")]
    public class userAccount
    {
        [Column("user_id"), Key]
        public int userId { get; set; }

        [Column("user_name")]
        [Display(Name = "User Name")]
        public string userName { get; set; }

        [Column("password_hash")]
        [Display(Name = "Password")]
        [DataType(DataType.Password)]
        public string passwordHash { get; set; }

        [Column("full_name")]
        [Display(Name = "Full Name")]
        public string fullName { get; set; }

        [Column("email_address")]
        [Display(Name = "Email Address")]
        [EmailAddress]
        public string emailAddress { get; set; }

        [Column("is_active")]
        public Boolean isActive { get; set; } = true;

        [Column("created_date")]
        public DateTime createdDate { get; }

        [Column("role_id")]
        public int roleId { get; set; } = 1;  // Set to default Subscriber role

        [Column("phone_number")]
        [Display(Name = "Phone Number")]
        [Phone]
        public string telePhone { get; set; }
    }
}
