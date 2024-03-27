using Hospital_Management_System.Data;
using Hospital_Management_System.Models;
using Microsoft.AspNetCore.Mvc;

namespace Hospital_Management_System.Controllers
{
    public class AccountController : Controller
    {
        // fixes context mismatch issue?
        private readonly Hospital_Management_SystemContext _context;
        public AccountController(Hospital_Management_SystemContext context)
        {
            _context = context;
        }

        [HttpGet] //inferred
        public IActionResult Register()
        {
            return View();
        }


        [HttpPost]
        public async Task<IActionResult> Register(
            [Bind("UserName, FirstName, LastName, Email, Password, ConfirmPassword")] UserAccount newUserAccount
        )
        {
            if(ModelState.IsValid)
            {
                /*UserContext db = new UserContext();
                db.UserAccounts.Add(userAccount);
                db.SaveChanges();*/

                _context.Add(newUserAccount);
                await _context.SaveChangesAsync();

                ModelState.Clear();
                ViewBag.Message = newUserAccount.FirstName + " " + newUserAccount.LastName + " successfully registered.";
            }
            return View();
        }


/*        public JsonResult IsUserNameAvailable(string UserName)
        {
            return Json(!_context.UserAccount.Any(x => x.UserName == UserName), JsonRequestBehavior.AllowGet);
        }*/


        [HttpGet] //inferred
        public IActionResult Login()
        {
            return View();
        }


        [HttpPost]
        public IActionResult Login(
            [Bind("UserName, Password")] UserAccount loginCreds
        )
        {
            /*UserContext db = new UserContext();

            var user = db.UserAccounts.Where(u => u.UserName == userAccount.UserName &&
                                                  u.Password == userAccount.Password
                                            ).FirstOrDefault();*/

            var user = _context.UserAccount.Where(u => u.UserName == loginCreds.UserName &&
                                                             u.Password == loginCreds.Password
                                                       ).FirstOrDefault();

            if (user!=null)
            {
/*                Session["userID"] = user.UserID.ToString();
                Session["userName"] = user.UserName.ToString();*/
/*                FormsAuthentication.SetAuthCookie(user.UserName, false);*/
                return RedirectToAction("LoggedIn");
                /*ViewBag.message = "Login Success";
                return View("LoginSuccess");*/
            }
            else
            {
                ViewBag.Message = "Invalid Username or Password";
                /*ModelState.AddModelError("", "Username or password is incorrect.");*/
                return View();
                /*ViewBag.message = "Login Failed";
                return View("Login");*/
            }            
        }


        /*        public IActionResult LoggedIn()
                {
                    if(Session["userId"]!=null)
                    {
                        return View();
                    }
                    else
                    {
                        return RedirectToAction("Login");
                    }
                }*/


        public IActionResult Logout()
        {
/*            if (Session["userId"] != null)
            {
                Session.Abandon();
            }*/
/*            return RedirectToAction("Login");*/
/*            FormsAuthentication.SignOut();*/
            return RedirectToAction("Index", "Home");
        }


        // you can use Index to show a list of registered users if needed
        public ActionResult Index()
        {
            /*UserContext db = new Hospital_Management_SystemContext();

            return View(db.UserAccounts.ToList());*/
            return View(_context.UserAccount.ToList());
        }
    }
}
