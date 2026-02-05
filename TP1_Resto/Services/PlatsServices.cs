using TP1_Resto.Models;

namespace TP1_Resto.Services
{
    public class PlatsServices
    {
        public List<Plat> listePlat;

        public PlatsServices()
        {
			listePlat = new List<Plat>()
			{
				new Plat { Id = 1, Nom = "Bœuf Bourguignon", Prix = 18.5, Categorie = "Plat principal", RestaurantId = 1 },
				new Plat { Id = 2, Nom = "Soupe à l'oignon", Prix = 7.5, Categorie = "Entrée", RestaurantId = 1 },

				new Plat { Id = 3, Nom = "Lasagnes maison", Prix = 14.0, Categorie = "Plat principal", RestaurantId = 3 },
				new Plat { Id = 4, Nom = "Bruschetta", Prix = 6.0, Categorie = "Entrée", RestaurantId = 3 },

				new Plat { Id = 5, Nom = "Pizza Margherita", Prix = 12.0, Categorie = "Plat principal", RestaurantId = 4 },
				new Plat { Id = 6, Nom = "Tiramisu", Prix = 6.5, Categorie = "Dessert", RestaurantId = 4 },

				new Plat { Id = 7, Nom = "Sushi Saumon", Prix = 16.0, Categorie = "Plat principal", RestaurantId = 5 },
				new Plat { Id = 8, Nom = "Soupe Miso", Prix = 4.5, Categorie = "Entrée", RestaurantId = 5 },

				new Plat { Id = 9, Nom = "Ramen Tonkotsu", Prix = 15.0, Categorie = "Plat principal", RestaurantId = 6 },
				new Plat { Id = 10, Nom = "Mochi", Prix = 5.0, Categorie = "Dessert", RestaurantId = 6 },

				new Plat { Id = 11, Nom = "Tacos Bœuf", Prix = 10.0, Categorie = "Plat principal", RestaurantId = 7 },
				new Plat { Id = 12, Nom = "Guacamole", Prix = 6.0, Categorie = "Entrée", RestaurantId = 7 },

				new Plat { Id = 13, Nom = "Quesadillas", Prix = 9.5, Categorie = "Plat principal", RestaurantId = 8 },
				new Plat { Id = 14, Nom = "Churros", Prix = 5.5, Categorie = "Dessert", RestaurantId = 8 },

				new Plat { Id = 15, Nom = "Salade César", Prix = 11.0, Categorie = "Salade", RestaurantId = 2 },
				new Plat { Id = 16, Nom = "Steak Frites", Prix = 17.0, Categorie = "Plat principal", RestaurantId = 2 },

				new Plat { Id = 17, Nom = "Cheesecake", Prix = 6.5, Categorie = "Dessert", RestaurantId = 1 },
				new Plat { Id = 18, Nom = "Tempura de légumes", Prix = 8.0, Categorie = "Entrée", RestaurantId = 5 },

				new Plat { Id = 19, Nom = "Salade de quinoa", Prix = 9.0, Categorie = "Salade", RestaurantId = 6 },
				new Plat { Id = 20, Nom = "Fondant au chocolat", Prix = 7.0, Categorie = "Dessert", RestaurantId = 2 }
			};
        }

        public List<Plat> getAllPlats()
        {
			return listePlat;
		}
    }
}
