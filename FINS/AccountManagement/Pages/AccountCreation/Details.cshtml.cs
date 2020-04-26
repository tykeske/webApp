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
    public class DetailsModel : PageModel
    {
        private readonly AccountManagement.Data.AccountContext _context;

        public DetailsModel(AccountManagement.Data.AccountContext context)
        {
            _context = context;
        }

        public userAccount userAccount { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            userAccount = await _context.userAccounts.FirstOrDefaultAsync(m => m.userId == id);

            if (userAccount == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
