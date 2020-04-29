/*
    Author:         Nick Dechativong
    Created Date:   04/23/2020
    Class:          CIS 234A
    Objective:      Setting up context for database session to use with Entity Framework
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using AccountManagement.Models;


namespace AccountManagement.Data
{
    public class accountContext : DbContext
    {
        public accountContext (DbContextOptions<accountContext> options)
            : base(options)
        {
        }

        public DbSet<AccountManagement.Models.userAccount> userAccount { get; set; }
    }
}
