using Microsoft.AspNetCore.Mvc;

namespace PierresSavoryAndSweet.Controllers
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