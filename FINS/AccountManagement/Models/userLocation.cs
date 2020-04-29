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
        [Column("user_id"), Key]
        public int userId { get; set; }
        [Column("location_id"), Key]
        public int locationId { get; set; }
    }
}
