using System;
using System.Globalization;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.Owin.Security;
using VienautoMobile.Models;
using VienautoMobile.Controllers;
using VienautoMobile.Models.Form;
using System.Collections.Generic;
using Vienauto.Service.Application;

namespace VienautoMobile.Controllers
{
    [Authorize]
    public class AccountController : MobileController
    {
        private readonly IAccountService _accountService;

        public AccountController() : this(new AccountService())
        {

        }

        public AccountController(IAccountService accountService)
        {
            _accountService = accountService;
        }
        
        [AllowAnonymous]
        public ActionResult SignIn(string returnUrl)
        {
            ViewBag.ReturnUrl = returnUrl;
            return View();
        }

        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public ActionResult SignIn(AccountFormModel model, string returnUrl)
        {
            ValidateFormModel(model);
            if (ModelState.IsValid)
            {
                var isLoginSuccessful = LoginAction(() => _accountService.AuthenticateUser(model.UserName, model.PassWord));
                if (isLoginSuccessful)
                    return RedirectToLocal(returnUrl);
                else
                    ModelState.AddModelError("Login", "Đăng nhập thất bại!");
            }
            //var errors = ModelState.Values.SelectMany(value => value.Errors).ToList();
            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult SignOut()
        {
            LogOutAction();
            return View();
        }

        private ActionResult RedirectToLocal(string returnUrl)
        {
            if (Url.IsLocalUrl(returnUrl))
            {
                return Redirect(returnUrl);
            }
            return RedirectToAction("Index", "Home");
        }

        private void ValidateFormModel(AccountFormModel model)
        {
            if (string.IsNullOrEmpty(model.UserName))
                ModelState.AddModelError("UserName", "Chưa nhập tên đăng nhập");
            else if (string.IsNullOrEmpty(model.PassWord))
                ModelState.AddModelError("PassWord", "Chưa nhập mật khẩu");
        }
    }
}