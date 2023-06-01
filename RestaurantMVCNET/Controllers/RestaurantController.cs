using Microsoft.AspNetCore.Mvc;

namespace RestaurantMVCNET.Controllers
{
    public class RestaurantController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {

            return View();
        }
    }
}
