using Owin;
using System;
using Microsoft.Owin;
using System.Security.Claims;
using Microsoft.AspNet.Identity;
using Microsoft.Owin.Security.Cookies;

namespace VienautoRemake
{
    public partial class Startup
    {
        // For more information on configuring authentication, please visit http://go.microsoft.com/fwlink/?LinkId=301864
        public void ConfigureAuth(IAppBuilder app)
        {
            System.Web.Helpers.AntiForgeryConfig.UniqueClaimTypeIdentifier = ClaimTypes.Email;
            app.UseCookieAuthentication(new CookieAuthenticationOptions
            {
                ExpireTimeSpan = TimeSpan.FromMinutes(30),
                LoginPath = new PathString("/Account/SignIn"),
                CookieSecure = CookieSecureOption.SameAsRequest,
                AuthenticationType = DefaultAuthenticationTypes.ApplicationCookie
            });
        }
    }
}
