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
    public class DeleteModel : PageModel
    {
        private readonly AccountManagement.Data.AccountManagementContext _context;

        public DeleteModel(AccountManagement.Data.AccountManagementContext context)
        {
            _context = context;
        }

        [BindProperty]
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

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            account = await _context.account.FindAsync(id);

            if (account != null)
            {
                _context.account.Remove(account);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
