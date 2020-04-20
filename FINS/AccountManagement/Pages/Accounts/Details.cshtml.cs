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
    public class DetailsModel : PageModel
    {
        private readonly AccountManagement.Data.AccountManagementContext _context;

        public DetailsModel(AccountManagement.Data.AccountManagementContext context)
        {
            _context = context;
        }

        public account account { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            account = await _context.account.FirstOrDefaultAsync(m => m.userId == id);

            if (account == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
