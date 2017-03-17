
namespace MovieTutorial.App.Pages
{
    using Serenity;
    using Serenity.Web;
    using System.Web.Mvc;

    [RoutePrefix("App/Movie"), Route("{action=index}")]
    [PageAuthorize(typeof(Entities.MovieRow))]
    public class MovieController : Controller
    {
        public ActionResult Index()
        {
            return View("~/Modules/App/Movie/MovieIndex.cshtml");
        }
    }
}