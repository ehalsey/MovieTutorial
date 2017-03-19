
namespace MovieTutorial.App.Pages
{
    using Serenity;
    using Serenity.Web;
    using System.Web.Mvc;

    [RoutePrefix("App/Person"), Route("{action=index}")]
    [PageAuthorize(typeof(Entities.PersonRow))]
    public class PersonController : Controller
    {
        public ActionResult Index()
        {
            return View("~/Modules/App/Person/PersonIndex.cshtml");
        }
    }
}