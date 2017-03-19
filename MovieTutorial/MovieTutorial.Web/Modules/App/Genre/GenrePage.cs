
namespace MovieTutorial.App.Pages
{
    using Serenity;
    using Serenity.Web;
    using System.Web.Mvc;

    [RoutePrefix("App/Genre"), Route("{action=index}")]
    [PageAuthorize(typeof(Entities.GenreRow))]
    public class GenreController : Controller
    {
        public ActionResult Index()
        {
            return View("~/Modules/App/Genre/GenreIndex.cshtml");
        }
    }
}