using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using AccountManagement.Data;
using AccountManagement.Models;

namespace AccountManagement.Pages.AccountCreation
{
    public class IndexModel : PageModel
    {
        private readonly AccountManagement.Data.AccountContext _context;

        public IndexModel(AccountManagement.Data.AccountContext context)
        {
            _context = context;

            if (context.userAccounts.Any())
            {
                return;   // DB has been seeded
            }
        }

        public IList<userAccount> userAccount { get;set; }

        public async Task OnGetAsync()
        {
            userAccount = await _context.userAccounts.ToListAsync();
        }
    }
}
