using System.Web.Optimization;

namespace Mvc.TwitterBootstrap3.Web
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new StyleBundle("~/assets/css/bootstrap")
                .Include("~/Content/css/default.css"));

            bundles.Add(new ScriptBundle("~/assets/js/bootstrap")
                .Include("~/Scripts/bootstrap/*transition.js")
                .Include("~/Scripts/bootstrap/*alert.js")
                //.Include("~/Scripts/bootstrap/*button.js")
                //.Include("~/Scripts/bootstrap/*carousel.js")
                .Include("~/Scripts/bootstrap/*collapse.js")
                .Include("~/Scripts/bootstrap/*dropdown.js")
                .Include("~/Scripts/bootstrap/*modal.js")
                //.Include("~/Scripts/bootstrap/*tooltip.js")
                //.Include("~/Scripts/bootstrap/*popover.js")
                //.Include("~/Scripts/bootstrap/*scrollspy.js")
                //.Include("~/Scripts/bootstrap/*tab.js")
                //.Include("~/Scripts/bootstrap/*affix.js")
            );

            bundles.Add(new ScriptBundle("~/assets/jQuery")
                .Include("~/Scripts/jquery-{version}.js"));
        }
    }
}