/*
    Author:         Nick Dechativong
    Created Date:   04/23/2020
    Class:          CIS 234A
    Objective:      This controller handles user account interaction and any CRUD operations
*/

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


namespace AccountManagement.Controllers
{
    public class AccountController : Controller
    {
        private readonly accountContext _context;

        public List<userSubscription> userSubscriptionList;
        public List<userLocation> userLocationList;

        public AccountController(accountContext context)
        {
            _context = context;
        }

        // GET: userAccounts
        public async Task<IActionResult> Index()
        {
            return View(await _context.userAccount.ToListAsync());
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

        private bool userAccountExists(int id)
        {
            return _context.userAccount.Any(e => e.userId == id);
        }

        // GET: userAccounts/Profile/5
        public async Task<IActionResult> Profile(int id)
        {
            // TODO: Check for URL tampering

            // Find user record based on userId
            var userAccount = await _context.userAccount
                .Include(u => u.userLocations)
                .FirstOrDefaultAsync(m => m.userId == id);

            // If user record cannot be found
            if (userAccount == null)
            {
                return NotFound();
            }

            // Assign attributes from account model to registration view model
            var thisRegistration = new userRegistration
            {
                userName = userAccount.userName,
                password = userAccount.passwordHash,
                fullName = userAccount.fullName,
                emailAddress = userAccount.emailAddress,
                phoneNumber = userAccount.telePhone
            };

            // Create hashset for lookup registered location
            var registeredLocation = new HashSet<int>(
                    userAccount.userLocations.Select(l => l.locationId));

            userSubscriptionList = new List<userSubscription>();

            // Iterate through each pantry location and set subscribed flag accordingly
            foreach (var pantry in _context.pantryLocation) 
            {
                userSubscriptionList.Add(new userSubscription
                    {
                        locationId = pantry.locationId,
                        locationName = pantry.locationName,
                        subscribed = registeredLocation.Contains(pantry.locationId)
                    });
            }

            thisRegistration.userSubscriptions = userSubscriptionList;

            return View(thisRegistration);
        }

        // GET: userAccounts/Register
        public IActionResult Register()
        {
            // Assign attributes from account model to registration view model
            var thisRegistration = new userRegistration
            {
                userName = "",
                password = "",
                fullName = "",
                emailAddress = "",
                phoneNumber = ""
            };

            userSubscriptionList = new List<userSubscription>();

            // Iterate through each pantry location and add them for selection
            foreach (var pantry in _context.pantryLocation)
            {
                userSubscriptionList.Add(new userSubscription
                {
                    locationId = pantry.locationId,
                    locationName = pantry.locationName,
                    subscribed = false
                });
            }

            // Assign the subccription list to the new user account
            thisRegistration.userSubscriptions = userSubscriptionList;

            return View(thisRegistration);
        }

        public void updateSubscriptions(string[] selectedLocations, userAccount userToUpdate)
        { 
            if (selectedLocations == null)
            {
                userToUpdate.userLocations = new List<userLocation>();
                return;
            }

            var selectedLocationsHS = new HashSet<string>(selectedLocations);

            // New user account
            if (userToUpdate.userLocations == null)
            {
                userLocationList = new List<userLocation>();

                // Iterate through each pantry location and assigned based on user selection
                foreach (var location in _context.pantryLocation)
                {
                    if (selectedLocationsHS.Contains(location.locationId.ToString()))
                    {
                        userLocationList.Add(new userLocation
                        {
                            locationId = location.locationId,
                            userId = userToUpdate.userId
                        });
                    }
                }

                // Assign the subccription list to the new user account
                userToUpdate.userLocations = userLocationList;
            }
            else  // Existing users
            {
                var userSubscriptions = new HashSet<int>(userToUpdate.userLocations.Select(l => l.pantryLocation.locationId));

                foreach (var location in _context.pantryLocation)
                {
                    if (selectedLocationsHS.Contains(location.locationId.ToString()))
                    {
                        // Location not subscribed before, add new one
                        if (!userSubscriptions.Contains(location.locationId))
                        {
                            userToUpdate.userLocations.Add(
                                new userLocation
                                {
                                    userId = userToUpdate.userId,
                                    locationId = location.locationId
                                });
                        }
                    }
                    else
                    {   // Location was unsubscribed, remove it
                        if (userSubscriptions.Contains(location.locationId))
                        {
                            userLocation locationToRemove = userToUpdate.userLocations.SingleOrDefault(i => i.locationId == location.locationId);
                            _context.Remove(locationToRemove);
                        }
                    }
                }
            }
        }


        // POST: userAccounts/Register
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Register(userRegistration userRegistration, string[] selectedLocations)
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
                // Store new user account
                _context.Add(newAccount);
                await _context.SaveChangesAsync();

                // Store user location assignment
                updateSubscriptions(selectedLocations, newAccount);
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
                        var claims = new List<Claim>();

                        claims.Add(new Claim(ClaimTypes.Name, userAccount.userName));
                        claims.Add(new Claim(ClaimTypes.Sid, userAccount.userId.ToString()));

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
        // GET: /Account/Logout
        [HttpGet]
        [AllowAnonymous]
        public IActionResult Logout(string returnUrl = null)
        {
            ViewData["ReturnUrl"] = returnUrl;
            return View();
        }

        //
        // POST: /Account/Logout
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Logout()
        {
            // Sign out user and delete their cookie
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
