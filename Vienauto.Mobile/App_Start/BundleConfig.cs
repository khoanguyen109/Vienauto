using System.Web;
using System.Web.Optimization;

namespace VienautoRemake
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/js/jquery").Include(
                        "~/Assets/js/core/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/js/jqueryval").Include(
                        "~/Assets/js/core/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/js/modernizr").Include(
                        "~/Assets/js/core/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/js/bootstrap").Include(
                      "~/Assets/js/core/bootstrap.js",
                      "~/Assets/js/core/respond.js"));

            bundles.Add(new ScriptBundle("~/bundles/js/login").Include(
                      "~/Assets/js/module/login/login.js"));

            bundles.Add(new StyleBundle("~/bundles/css/bootstrap").Include(
                      "~/Assets/css/core/bootstrap.css"));

            bundles.Add(new StyleBundle("~/bundles/css/login").Include(
                      "~/Assets/css/module/login/login.css"));
        }
    }
}
