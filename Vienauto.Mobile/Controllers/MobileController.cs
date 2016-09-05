using System;
using Vienauto.Core.Mvc;
using Vienauto.Service.Dto;
using System.Security.Claims;
using Vienauto.Service.Result;
using System.Collections.Generic;

namespace VienautoMobile.Controllers
{
    public class MobileController : BaseController
    {
        protected bool LoginAction(Func<ServiceResult<UserDto>> authenticateFunc, bool rememberMe = false)
        {
            var resultAuthenticate = authenticateFunc();
            if (resultAuthenticate.HasErrors)
                return false;

            var claimSet = new Dictionary<string, string>
            {
                { "FullName", resultAuthenticate.Target?.FullName },
                { ClaimTypes.Email, resultAuthenticate.Target?.UserName }
            };
            return LogIn(claimSet, rememberMe);
        }

        protected void LogOutAction()
        {
            base.LogOut();
        }
    }
}
