using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using OnlineRestaurantBookingSystem.Models;

namespace OnlineRestaurantBookingSystem.Controllers
{
    public class AccountController : Controller
    {
        private readonly RestaurantDbContext _dbContext;
        private readonly UserManager<IdentityUser> _userManager;
        private readonly SignInManager<IdentityUser> _signInManager;

        public AccountController(RestaurantDbContext dbContext,
                                    UserManager<IdentityUser> userManager,
                                                SignInManager<IdentityUser> signInManager)
        {
            _dbContext = dbContext;
            _userManager = userManager;
            _signInManager = signInManager;
        }

        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }
        [AutoValidateAntiforgeryToken]
        [HttpPost]
        public async Task<IActionResult> Register(Register registerModel)
        {
            if (ModelState.IsValid)
            {
                var user = new IdentityUser() { UserName = registerModel.UserName, Email = registerModel.UserEmail };
                var result = await _userManager.CreateAsync(user, registerModel.Password);

                if (result.Succeeded)
                {
                    return RedirectToAction("Login", "Account");
                }
            }
            return View(registerModel);

        }

        public async Task<IActionResult> LogOut()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("Index", "Home");
        }

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }


        [AutoValidateAntiforgeryToken]
        [HttpPost]
        public async Task<IActionResult> Login(LoginModel model)
        {
            if (ModelState.IsValid)
            {
                var user = await _userManager.FindByEmailAsync(model.UserEmail);

                if (user == null)
                {
                    ModelState.AddModelError("", "User not exists");
                    return View(model);

                }

                if (user != null)
                {
                    var PasswordResult = await _signInManager.PasswordSignInAsync(user, model.Password, true, true);
                    if (PasswordResult.Succeeded)
                    {
                        await _signInManager.SignInAsync(user, true);
                        return RedirectToAction("Index", "Home");
                    }
                    else
                    {
                        ModelState.AddModelError("", "Email or password is incorrect!");
                    }


                    //    var PasswordCheckResult = await _signInManager.CheckPasswordSignInAsync(user, model.Password, false);
                    //    if (PasswordCheckResult.Succeeded)
                    //    {
                    //        return RedirectToAction("Index", "Home");

                    //    }
                    //    else
                    //    {
                    //        ModelState.AddModelError("", "Email or Password is not valid");
                    //        return View(model);
                    //    }

                    //}
                    //else
                    //{
                    //    ModelState.AddModelError("", "Email or Password is not valid");
                    //    return View(model);
                    //}

                }
            }
            return View();

        }

    }
}