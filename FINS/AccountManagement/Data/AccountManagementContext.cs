using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using AccountManagement.Models;

namespace AccountManagement.Data
{
    public class AccountManagementContext : DbContext
    {
        public AccountManagementContext (DbContextOptions<AccountManagementContext> options)
            : base(options)
        {
        }

        public DbSet<AccountManagement.Models.user_account> account { get; set; }
    }
}
