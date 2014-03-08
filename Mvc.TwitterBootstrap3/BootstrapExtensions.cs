using System.Web.Mvc;
using Mvc.TwitterBootstrap3.Components;

namespace Mvc.TwitterBootstrap3
{
    public static class BootstrapExtensions
    {
        public static Bootstrap Bootstrap(this HtmlHelper htmlHelper)
        {
            return new Bootstrap(htmlHelper);
        }
    }
}
