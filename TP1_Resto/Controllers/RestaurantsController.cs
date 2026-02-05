using Microsoft.AspNetCore.Mvc;
using TP1_Resto.ViewModels.Restaurants;

namespace TP1_Resto.Controllers
{
    public class RestaurantsController : Controller
    {
        public IActionResult Index()
        {
            return View(new RestaurantVM());
        }
    }
}
