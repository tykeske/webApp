using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using AccountManagement.Data;
using AccountManagement.Models;
using Microsoft.EntityFrameworkCore;

namespace AccountManagement.Pages.AccountCreation
{
    public class registerModel : PageModel
    {
        private readonly AccountManagement.Data.AccountContext _context;

        public registerModel(AccountManagement.Data.AccountContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public userAccount userAccount { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.userAccounts.Add(userAccount);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
