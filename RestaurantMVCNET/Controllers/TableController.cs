using Microsoft.AspNetCore.Mvc;

namespace RestaurantMVCNET.Controllers
{
    public class TableController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
