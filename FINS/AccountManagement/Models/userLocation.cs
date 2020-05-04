/*
    Author:         Nick Dechativong
    Created Date:   04/23/2020
    Class:          CIS 234A
    Objective:      This model is used to encapsulate user-location relationship data
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace AccountManagement.Models
{
    // Model for manage user-pantry location assignment entity
    public class userLocation
    {
        // Composite key is set in Fluent API
        [Column("user_id"), Key]
        public int userId { get; set; }
        [Column("location_id"), Required]
        public int locationId { get; set; }

        // Navigation
        public userAccount userAccount { get; set; }
        public pantryLocation pantryLocation { get; set; }
    }
}
