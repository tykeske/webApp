using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using AccountManagement.Data;
using AccountManagement.Models;

namespace AccountManagement.Pages.Accounts
{
    public class EditModel : PageModel
    {
        private readonly AccountManagement.Data.AccountManagementContext _context;

        public EditModel(AccountManagement.Data.AccountManagementContext context)
        {
            _context = context;
        }

        [BindProperty]
        public user_account account { get; set; }

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

        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(account).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!accountExists(account.userId))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool accountExists(int id)
        {
            return _context.account.Any(e => e.userId == id);
        }
    }
}
