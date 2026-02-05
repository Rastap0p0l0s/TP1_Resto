using System.Diagnostics;
using System.Xml.Serialization;
using Microsoft.AspNetCore.Mvc;
using TP1_Resto.Models;

using TP1_Resto.ViewModels.Accueil;

namespace TP1_Resto.Controllers
{

    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View(new AccueilVM());
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
