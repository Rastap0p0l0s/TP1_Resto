using TP1_Resto.Models;
using TP1_Resto.Services;

namespace TP1_Resto.ViewModels.Restaurants
{
    public class RestaurantVM
    {
        private RestaurantsService restaurantsService;
        private PlatsServices PlatsServices;

        public List<Restaurant> restaurants;

        public RestaurantVM() { 
            restaurantsService = new RestaurantsService();
            PlatsServices = new PlatsServices();

            restaurants = restaurantsService.GetRestaurantsInAlphabeticalOrder();

            foreach(Restaurant restaurant in restaurants)
            {
                restaurant.NbrPlats = PlatsServices.GetPlatsByResto(restaurant.Id).Count();
            }
        }
    }
}
