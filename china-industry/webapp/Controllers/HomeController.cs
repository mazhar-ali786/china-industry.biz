#region Using

using System.Web.Mvc;

#endregion

namespace SmartAdminMvc.Controllers{
    public class HomeController : Controller
    {
        // GET: home/index
        public ActionResult Index()
        {
            return View();
        }
    }
}