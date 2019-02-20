
using Microsoft.AspNetCore.Mvc;

namespace Packertracker.Controllers
{
    public class HomeController : Controller
    {

      [HttpGet("/")]
      public ActionResult Index()
      {
        return View();
      }

    }
}
