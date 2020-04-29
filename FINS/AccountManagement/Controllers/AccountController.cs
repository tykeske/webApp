using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using AccountManagement.Data;
using AccountManagement.Models;
using AccountManagement.ViewModels;
using Microsoft.AspNetCore.Authorization;
using AccountManagement.Services;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Authentication;
using System.Security.Claims;
using Microsoft.AspNetCore.Authentication.Cookies;

/*
    Author: Nick Dechativong
    Class: CIS 234A
    Objective: This controller handles user account interaction and any CRUD operations
*/

namespace AccountManagement.Controllers
{
    public class AccountController : Controller
    {
        private readonly accountContext _context;

        public AccountController(accountContext context)
        {
            _context = context;
        }

        // GET: userAccounts
        public async Task<IActionResult> Index()
        {
            return View(await _context.userAccount.ToListAsync());
        }

        // GET: userAccounts/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var userAccount = await _context.userAccount
                .FirstOrDefaultAsync(m => m.userId == id);
            if (userAccount == null)
            {
                return NotFound();
            }

            return View(userAccount);
        }

        // GET: userAccounts/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: userAccounts/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("userId,userName,passwordHash,fullName,emailAddress,isActive,roleId,telePhone")] userAccount userAccount)
        {
            if (ModelState.IsValid)
            {
                _context.Add(userAccount);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(userAccount);
        }

        // GET: userAccounts/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var userAccount = await _context.userAccount.FindAsync(id);
            if (userAccount == null)
            {
                return NotFound();
            }
            return View(userAccount);
        }

        // POST: userAccounts/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("userId,userName,passwordHash,fullName,emailAddress,isActive,roleId,telePhone")] userAccount userAccount)
        {
            if (id != userAccount.userId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(userAccount);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!userAccountExists(userAccount.userId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(userAccount);
        }

        // GET: userAccounts/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var userAccount = await _context.userAccount
                .FirstOrDefaultAsync(m => m.userId == id);
            if (userAccount == null)
            {
                return NotFound();
            }

            return View(userAccount);
        }

        // POST: userAccounts/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var userAccount = await _context.userAccount.FindAsync(id);
            _context.userAccount.Remove(userAccount);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool userAccountExists(int id)
        {
            return _context.userAccount.Any(e => e.userId == id);
        }

        // GET: userAccounts/Profile/5
        public async Task<IActionResult> Profile(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var userAccount = await _context.userAccount
                .FirstOrDefaultAsync(m => m.userId == id);
            if (userAccount == null)
            {
                return NotFound();
            }

            return View(userAccount);
        }

        // GET: userAccounts/Register

        // TODO: Add model validation for unique username
        // https://docs.microsoft.com/en-us/aspnet/core/mvc/models/validation?view=aspnetcore-3.1
        public IActionResult Register()
        {
            return View();
        }

        // POST: userAccounts/Register

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Register(userRegistration userRegistration)
        {

            // Get service class to use for password hashing
            utilityService util = new utilityService();

            // Use Identity Management for password hashing
            var pwdHasher = new PasswordHasher<string>();

            // Assign attributes from registration view model to account model
            var newAccount = new userAccount
            {
                userName = userRegistration.userName,
                //passwordHash = util.passwordHasher(userRegistration.password),
                passwordHash = pwdHasher.HashPassword(null, userRegistration.password),
                fullName = userRegistration.fullName,
                emailAddress = userRegistration.emailAddress,
                telePhone = userRegistration.phoneNumber
            };

            // Commit the new accont data
            if (ModelState.IsValid)
            {
                _context.Add(newAccount);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(newAccount);
        }


        //
        // GET: /Account/Login
        [HttpGet]
        [AllowAnonymous]
        public IActionResult Login(string returnUrl = null)
        {
            ViewData["ReturnUrl"] = returnUrl;
            return View();
        }

        //
        // POST: /Account/Login
        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(userLogin userLogin, string returnUrl = null)
        {
            ViewData["ReturnUrl"] = returnUrl;

            if (ModelState.IsValid)
            {
                // Find if the user exists
                var userAccount = await _context.userAccount
                    .FirstOrDefaultAsync(m => m.userName == userLogin.userName);

                // Found matching username in the accounts
                if (userAccount != null)
                {
                    // Hash the provided password and compare with the user account
                    var pwdHasher = new PasswordHasher<string>();
                    if (pwdHasher.VerifyHashedPassword(null, userAccount.passwordHash, userLogin.password) == PasswordVerificationResult.Success)
                    {
                        // Claim the identity of the user
                        var claims = new List<Claim>
                        {
                            new Claim(ClaimTypes.Name, userLogin.userName)
                        };

                        var claimsIdentity = new ClaimsIdentity(
                            claims, CookieAuthenticationDefaults.AuthenticationScheme);

                        // Store the claim information in encrypted cookie
                        await HttpContext.SignInAsync(
                                CookieAuthenticationDefaults.AuthenticationScheme,
                                new ClaimsPrincipal(claimsIdentity));

                        // Redirect after login success
                        return RedirectToAction("Profile", new { id = userAccount.userId });
                    }
                    else
                    {
                        // Invalid password
                        ModelState.AddModelError(string.Empty, "The password is invalid.");
                        return View(userLogin);
                    }
                }
                else
                {
                    // Invalid username
                    ModelState.AddModelError(string.Empty, "The username is invalid.");
                    return View(userLogin);
                }
            }
            // If we got this far, something failed, redisplay form
            return View(userLogin);
        }

        //
        // POST: /Account/Logout
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync(
                CookieAuthenticationDefaults.AuthenticationScheme);

            return RedirectToAction(nameof(HomeController.Index), "Home");
        }

        //
        // validate email existence
        [AcceptVerbs("GET", "POST")]
        public IActionResult VerifyEmail(string emailAddress)
        {
            if (_context.userAccount.Any(e => e.emailAddress == emailAddress))
            {
                return Json($"An email {emailAddress} is already in use.");
            }

            return Json(true);
        }

        //
        // validate username existence
        [AcceptVerbs("GET", "POST")]
        public IActionResult VerifyUsername(string userName)
        {
            if (_context.userAccount.Any(e => e.userName == userName))
            {
                return Json($"A user {userName} already exists.");
            }

            return Json(true);
        }

        //
        // validate PCC password policy
        [AcceptVerbs("GET", "POST")]
        public IActionResult VerifyPassword(string password)
        {
            if (!ModelState.IsValid)
            {
                return Json($"Phone {password} has an invalid format. Format: ###-###-####");
            }

            return Json(true);
        }

        #region Helpers

        private void AddErrors(IdentityResult result)
        {
            foreach (var error in result.Errors)
            {
                ModelState.AddModelError(string.Empty, error.Description);
            }
        }

        private IActionResult RedirectToLocal(string returnUrl)
        {
            if (Url.IsLocalUrl(returnUrl))
            {
                return Redirect(returnUrl);
            }
            else
            {
                return RedirectToAction(nameof(HomeController.Index), "Home");
            }
        }

        #endregion
    }
}
