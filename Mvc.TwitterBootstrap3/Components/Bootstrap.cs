using System.Web.Mvc;

namespace Mvc.TwitterBootstrap3.Components
{
    public sealed class Bootstrap
    {
        internal readonly HtmlHelper HtmlHelper;

        private Bootstrap()
        {}

        internal Bootstrap(HtmlHelper htmlHelper)
        {
            HtmlHelper = htmlHelper;
        }
    }
}
