using Microsoft.AspNetCore.Mvc;

namespace Lettuce.Controllers
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