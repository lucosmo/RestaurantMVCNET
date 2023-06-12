using Microsoft.AspNetCore.Mvc;
using RestaurantMVCNET.Models;
using RestaurantMVCNET.Services;

namespace RestaurantMVCNET.Controllers
{
    public class RestaurantController : Controller
    {
        private readonly IRestaurantService _db;

        public RestaurantController(IRestaurantService db)
        {
            _db = db;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var allRestaurants = await _db.GetAllRestaurants();
            return View(allRestaurants);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Restaurant restuarant)
        {
           // try
            //{
                await _db.AddRestaurant(restuarant);
                return RedirectToAction("Index");
           // }
           /* catch (Exception ex)
            {


                ErrorViewModel addingError = new ErrorViewModel();
                addingError.Message = ex.Message;
                return View("Error", addingError);


            }*/
        }

        [HttpGet]
        public async Task<IActionResult> Delete(int id)
        {
            var model = await _db.GetRestaurant(id);
            if (model == null)
            {
                return View("Error");
            }
            else
            {
                return View(model);
            }
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(int id, IFormCollection fc)
        {
            await _db.RemoveRestaurant(id);
            return RedirectToAction("Index");
        }
    }
}
