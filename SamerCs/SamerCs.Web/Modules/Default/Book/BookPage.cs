
namespace SamerCs.Default.Pages
{
    using Serenity;
    using Serenity.Web;
    using System.Web.Mvc;

    [RoutePrefix("Default/Book"), Route("{action=index}")]
    [PageAuthorize(typeof(Entities.BookRow))]
    public class BookController : Controller
    {
        public ActionResult Index()
        {
            return View("~/Modules/Default/Book/BookIndex.cshtml");
        }
    }
}