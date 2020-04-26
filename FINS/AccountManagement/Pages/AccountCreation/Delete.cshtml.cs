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
    public class DeleteModel : PageModel
    {
        private readonly AccountManagement.Data.AccountContext _context;

        public DeleteModel(AccountManagement.Data.AccountContext context)
        {
            _context = context;
        }

        [BindProperty]
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

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            userAccount = await _context.userAccounts.FindAsync(id);

            if (userAccount != null)
            {
                _context.userAccounts.Remove(userAccount);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
