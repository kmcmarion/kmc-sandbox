using DevTrends.MvcDonutCaching;
using System.Collections.Generic;
using System.Web.Mvc;
using Umbraco.Core.Models;
using Umbraco.Web;
using Umbraco.Web.Mvc;
using Umbraco.Web.Composing;
using KMC_New.Models;


namespace KMC_New.Controllers.Surface
{
    //public class SiteLayoutController : SurfaceController
    //{
    //    [ChildActionOnly]
    //    [DonutOutputCache(CacheProfile = "OneMonth")]
    //    public ActionResult RenderMainNavigation()
    //    {
    //        //IPublishedContent homePage = CurrentPage.AncestorOrSelf("home");
    //        //IEnumerable<IPublishedContent> model = homePage.Children(x => x.IsVisible());

    //        //return PartialView("/Views/Partials/Navigation/_MainNavigation.cshtml", model);
    //    }
    //}
}