using Hospital_Management_System.Data;
using Hospital_Management_System.Models;
using Microsoft.AspNetCore.Mvc;

using System.Security.Claims;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;

namespace Hospital_Management_System.Controllers
{
    public class AccountController : Controller
    {
        private readonly Hospital_Management_SystemContext _context;
        private readonly SignInManager<IdentityUser> _signInManager;
        private readonly UserManager<IdentityUser> _userManager;

        public AccountController(Hospital_Management_SystemContext context, UserManager<IdentityUser> userManager, SignInManager<IdentityUser> signInManager)
        {
            _context = context;
            _userManager = userManager;
            _signInManager = signInManager;
        }

        // you can use Index to show a list of registered users if needed
        public ActionResult Index()
        {
            return View(_context.UserAccount.ToList());
        }

        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Register(
            [Bind("UserName, FirstName, LastName, Email, Password, ConfirmPassword")] UserAccount newUserAccount
        )
        {
            if(ModelState.IsValid)
            {
                _context.Add(newUserAccount); //Adds new account to database
                _context.SaveChangesAsync();

                /*//Add new account to user manager
                var user = new IdentityUser { UserName = newUserAccount.UserName, Email = newUserAccount.Email };
                var result = _userManager.CreateAsync(user, newUserAccount.Password);*/

                ModelState.Clear();
                ViewBag.Message = newUserAccount.FirstName + " " + newUserAccount.LastName + " successfully registered.";

                /*_signInManager.SignInAsync(user, isPersistent: false); //Sign in new account using signinmanager*/
            }
            return View();
        }


/*        public JsonResult IsUserNameAvailable(string UserName) //idk where to get JsonRequestBehavior from
        {
            return Json(!_context.UserAccount.Any(x => x.UserName == UserName), JsonRequestBehavior.AllowGet);
        }*/


        [HttpGet]
        public IActionResult Login()
        {
            /*if(_signInManager.IsSignedIn(User)) //if user is already signed in, push them away from this page
            {
                return RedirectToAction("Index", "Home");
            }*/

            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login([Bind("UserName, Password")] UserAccount loginCreds)
        {
            var user = _context.UserAccount.Where(u => u.UserName == loginCreds.UserName &&
                                                       u.Password == loginCreds.Password
                                                 ).FirstOrDefault();
            //^retrives user from database if they exist

            if (user!=null) //If user exists
            {
                /*var result = await _signInManager.PasswordSignInAsync(user.UserName,user.Password, true, lockoutOnFailure: true);*/
                //^ use SignInManager to sign in user

                /*if (result.Succeeded) //if sign in succeeds send them to celebration page
                {
                    return RedirectToAction("LoginSuccessful");
                }
                return View();*/
                return RedirectToAction("LoginSuccessful");
            }
            else //Says login faile and keeps them on page
            {
                ViewBag.Message = "Invalid Username or Password";
                return View();
            }            
        }

        public IActionResult LoginSuccessful() //Tells the user that they signed in
        {
            return View();
        }


        public async Task<IActionResult> Logout() //Preforms the signout action and returns user to homepage
        {
            /*await _signInManager.SignOutAsync();*/

            return RedirectToAction("Index", "Home");
        }
    }
}
