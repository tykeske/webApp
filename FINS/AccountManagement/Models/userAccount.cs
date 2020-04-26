using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AccountManagement.Models
{
    public class userAccount
    {
        [Column("user_id"), Key]
        public int userId { get; set; }

        [Column("user_name"), Required]
        public string userName { get; set; }

        [Column("password_hash"), Required]
        public string passwordHash { get; set; }

        [Column("full_name"), Required]
        public string fullName { get; set; }

        [Column("email_address"), Required]
        public string emailAddress { get; set; }

        [Column("is_active")]
        public Boolean isActive { get; set; }

        [Column("created_date")]
        public DateTime createdDate { get; }

        [Column("role_id")]
        public int roleId { get; set; }

        [Column("phone_number"), DataType(DataType.PhoneNumber)]
        public string telePhone { get; set; }
    }
}
