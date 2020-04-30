/*
    Author:         Nick Dechativong
    Created Date:   04/23/2020
    Class:          CIS 234A
    Objective:      This model is used to encapsulate user role data
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace AccountManagement.Models
{
    // Model for manage user role entity
    public class userRole
    {
        [Column("role_id"), Key]
        public int roleId { get; set; }

        [Column("role_name")]
        public string roleName { get; set; }

        [Column("can_send_notification")]
        public Boolean canSendNotification { get; set; }

        [Column("can_view_log")]
        public Boolean canViewLog { get; set; }

        [Column("can_create_template")]
        public Boolean canCreateTemplate { get; set; }
    }
}
