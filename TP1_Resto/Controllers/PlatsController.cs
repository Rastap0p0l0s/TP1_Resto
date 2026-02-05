using Microsoft.AspNetCore.Mvc;
using TP1_Resto.ViewModels.Plats;

namespace TP1_Resto.Controllers
{
    public class PlatsController : Controller
    {
        public IActionResult Index()
        {
            return View(new PlatVM());
        }

        [Route("Views/Plats/{categories?}")]
        public IActionResult Categories(string categories)
        {
            return View(nameof(this.Index), new PlatVM(categories));
        }
    }
}
