using System.Web.Mvc;
using BlankEpiSite.Models.Pages;
using EPiServer.Web.Mvc;

namespace BlankEpiSite.Controllers
{
    public class StartPageController : PageController<StartPage>
    {
        public ActionResult Index(StartPage currentPage)
        {
            /* Implementation of action. You can create your own view model class that you pass to the view or
             * you can pass the page type for simpler templates */

            return View(currentPage);
        }
    }
}