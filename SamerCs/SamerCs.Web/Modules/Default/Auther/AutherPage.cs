
namespace SamerCs.Default.Pages
{
    using Serenity;
    using Serenity.Web;
    using System.Web.Mvc;

    [RoutePrefix("Default/Auther"), Route("{action=index}")]
    [PageAuthorize(typeof(Entities.AutherRow))]
    public class AutherController : Controller
    {
        public ActionResult Index()
        {
            return View("~/Modules/Default/Auther/AutherIndex.cshtml");
        }
    }
}