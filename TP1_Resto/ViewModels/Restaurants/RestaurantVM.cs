using System;
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

        public String CollapseStr(Restaurant resto)
        {
			//Source : https://stackoverflow.com/questions/2729752/converting-numbers-in-to-words-c-sharp première réponse, adapté en français
			string num = "";

			var unitees = new[] { "Zero", "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine", "Ten", "Eleven", "Twelve", "Thirteen", "Fourteen", "Fifteen", "Sixteen", "Seventeen", "Eighteen", "Nineteen" };
			var dizaines = new[] { "Sero", "Ten", "Twenty", "Thirty", "Forty", "Fifty", "Sixty", "Seventy", "Eighty", "Ninety" };

			if (resto.Id < 20)
				num += unitees[resto.Id];
			else
			{
				num += dizaines[resto.Id / 10];
				if ((resto.Id % 10) > 0)
					num += "-" + unitees[resto.Id % 10];
			}

            string retour = "collapse";
            retour += num;
            return retour;
		}

        public String IsFirstElement(Restaurant resto)
        {
            if(resto.Id == restaurants[0].Id)
            {
                return "true";
            }
            else
            {
                return "false";
            }
        }

		public String IsFirstElementShow(Restaurant resto)
		{
			if (resto.Id == restaurants[0].Id)
			{
				return "show";
			}
			else
			{
				return "";
			}
		}

		public String IsFirstElementColl(Restaurant resto)
		{
			if (resto.Id == restaurants[0].Id)
			{
				return "";
			}
			else
			{
				return "collapsed";
			}
		}
	}
}
