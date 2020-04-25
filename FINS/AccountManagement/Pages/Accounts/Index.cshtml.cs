using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using AccountManagement.Data;
using AccountManagement.Models;

namespace AccountManagement.Pages.Accounts
{
    public class IndexModel : PageModel
    {
        private readonly AccountManagement.Data.AccountManagementContext _context;

        public IndexModel(AccountManagement.Data.AccountManagementContext context)
        {
            _context = context;
        }

        public IList<user_account> account { get;set; }

        public async Task OnGetAsync()
        {
            account = await _context.account.ToListAsync();
        }
    }
}
