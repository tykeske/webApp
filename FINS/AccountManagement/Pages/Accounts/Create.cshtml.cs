using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using AccountManagement.Data;
using AccountManagement.Models;

namespace AccountManagement.Pages.Accounts
{
    public class CreateModel : PageModel
    {
        private readonly AccountManagement.Data.AccountManagementContext _context;

        public CreateModel(AccountManagement.Data.AccountManagementContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public account account { get; set; }

        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
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
