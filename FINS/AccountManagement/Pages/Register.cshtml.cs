using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using AccountManagement.Models;

namespace AccountManagement.Pages.Accounts
{
    public class registerModel : PageModel
    {
        private readonly AccountManagement.Data.AccountManagementContext _context;

        public registerModel(AccountManagement.Data.AccountManagementContext context)
        {
            _context = context;
        }
        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public user_account account { get; set; }

        public async Task<IActionResult> onPostAsync()
        {
            if (!ModelState.IsValid) 
            {
                return Page();
            }

            _context.account.Add(account);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}