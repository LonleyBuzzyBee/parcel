using Microsoft.AspNetCore.Mvc;

namespace Shipment.Controllers
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