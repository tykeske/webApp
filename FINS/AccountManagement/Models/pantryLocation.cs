/*
    Author:         Nick Dechativong
    Created Date:   04/23/2020
    Class:          CIS 234A
    Objective:      This model is used to manage pantry location data
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace AccountManagement.Models
{
    // Model for manage pantry location entity
    public class pantryLocation
    {
        [Column("location_id"), Key]
        public int locationId { get; set; }
        [Column("location_name"), Required]
        public string locationName { get; set; }
    }
}
