using System.Web.Mvc;
using VienautoMobile.Models.Form;
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
            //var errors = ModelState.Values.SelectMany(value => value.Errors).ToList();
            if (ModelState.IsValid)
            {
                var isLoginSuccessful = LoginAction(() => _accountService.AuthenticateUser(model.UserName, model.PassWord), new string[] { "FullName", "UserName" });
                if (isLoginSuccessful)
                    return RedirectToLocal(returnUrl);
                else
                    ModelState.AddModelError("Login", "Đăng nhập thất bại!");
            }
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
                return Redirect(returnUrl);
            return RedirectToAction("Index", "Home");
        }

        private void ValidateFormModel(AccountFormModel model)
        {
            if (string.IsNullOrEmpty(model.UserName))
                ModelState.AddModelError("UserName", "Chưa nhập email đăng nhập");
            else if (string.IsNullOrEmpty(model.PassWord))
                ModelState.AddModelError("PassWord", "Chưa nhập mật khẩu");
        }
    }
}