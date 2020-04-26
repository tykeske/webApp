using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using AccountManagement.Data;
using AccountManagement.Models;

namespace AccountManagement.Pages.AccountCreation
{
    public class CreateModel : PageModel
    {
        private readonly AccountManagement.Data.AccountContext _context;

        public CreateModel(AccountManagement.Data.AccountContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public userAccount userAccount { get; set; }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
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
