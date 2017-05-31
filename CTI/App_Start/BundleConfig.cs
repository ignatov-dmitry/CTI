using System.Web;
using System.Web.Optimization;

namespace CTI
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery.js",
                        "~/Scripts/jquery-ui.min.js"));

            bundles.Add(new ScriptBundle("~/bundles/rs-plugin").Include(
                        "~/Scripts/jquery.themepunch.tools.min.js",
                        "~/Scripts/jquery.themepunch.revolution.min.js"));

            bundles.Add(new ScriptBundle("~/bundles/scripts").Include(
                        "~/Scripts/prettify.js",
                        "~/Scripts/scripts.js",
                        "~/Scripts/custom.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/css/scripts.css",
                      "~/Content/rs-plugin/css/settings.css",
                      "~/Content/css/core-icons/core_style.css",
                      "~/Content/css/icons/style.css",
                      "~/Content/css/style.css"));
        }
    }
}
