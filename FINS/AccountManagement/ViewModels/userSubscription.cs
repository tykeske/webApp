/*
    Author:         Nick Dechativong
    Created Date:   05/03/2020
    Class:          CIS 234A
    Objective:      This view model is used to encapsulate subscription settings for the users
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using AccountManagement.Models;


namespace AccountManagement.ViewModels
{
    public class userSubscription
    {
        // Currently use location-based subscription, can be expanded to multi-list.
        [Key]
        public int locationId { get; set; }
        public string locationName { get; set; }
        public bool subscribed { get; set; }
    }
}
