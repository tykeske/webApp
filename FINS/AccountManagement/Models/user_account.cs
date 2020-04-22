using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace AccountManagement.Models
{
    public class user_account
    {
        [Key]
        public int userId { get; set; }

        public string userName { get; set; }
        public string passwordHash { get; set; }
        public string fullName { get; set; }
        public string emailAddress { get; set; }
        public int isActive { get; set; }
        public DateTime createdDate { get; set; }

        [DataType(DataType.PhoneNumber)]
        public string telePhone { get; set; }
    }
}
