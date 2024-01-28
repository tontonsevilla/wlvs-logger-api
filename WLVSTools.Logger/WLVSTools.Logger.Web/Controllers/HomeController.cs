using Microsoft.AspNetCore.Mvc;

namespace WLVSTools.Logger.Web.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
