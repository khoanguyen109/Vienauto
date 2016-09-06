using System;
using Vienauto.Core.Mvc;
using Vienauto.Service.Dto;
using System.Security.Claims;
using Vienauto.Service.Result;
using System.Collections.Generic;
using System.Reflection;

namespace VienautoMobile.Controllers
{
    public class MobileController : BaseController
    {
        /// <summary>
        /// Login with Owin middleware
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="authenticateFunc"></param>
        /// Method to verify user in database
        /// <param name="claimNames"></param>
        /// Pass claim names to store user values
        /// <param name="rememberMe"></param>
        /// Remember option
        /// <returns></returns>
        protected bool LoginAction<T>(Func<ServiceResult<T>> authenticateFunc, string[] claimNames, bool rememberMe = false)
        {
            var resultAuthenticate = authenticateFunc();
            if (resultAuthenticate.HasErrors)
                return false;

            var claimSet = new Dictionary<string, string>();
            var target = resultAuthenticate.Target;
            if (target == null)
                return false;

            var userInfo = typeof(T);
            PropertyInfo[] userProperties = userInfo.GetProperties();
            foreach (PropertyInfo property in userProperties)
            {
                var name = property.Name;
                if (Array.Exists(claimNames, c => c == name))
                {
                    var value = property.GetValue(target, null);
                    if (value is string)
                        claimSet.Add(name, value.ToString());
                }
            }
            return LogIn(claimSet, rememberMe);
        }

        protected void LogOutAction()
        {
            base.LogOut();
        }
    }
}
