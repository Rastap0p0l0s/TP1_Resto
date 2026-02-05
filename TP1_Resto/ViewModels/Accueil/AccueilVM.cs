using TP1_Resto.Models;
using TP1_Resto.Services;

namespace TP1_Resto.ViewModels.Accueil
{
    public class AccueilVM
    {
        private PlatsServices platsServices;
        private RestaurantsService restaurantsService;

        public List<Restaurant> MeilleursRestos { get; set; }

        public List<Plat> MeilleurPlats { get; set; }

        public AccueilVM()
        {
            platsServices = new PlatsServices();
            restaurantsService = new RestaurantsService();
            MeilleursRestos = restaurantsService.GetRestoTop3();
            MeilleurPlats = platsServices.GetPlatsTop3Price();
        }
    }
}
