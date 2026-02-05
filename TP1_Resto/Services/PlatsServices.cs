using TP1_Resto.Models;

namespace TP1_Resto.Services
{
    public class PlatsServices
    {
        public List<Plat> ListePlat= 
			   [new Plat { Id = 1, Nom = "Bœuf Bourguignon", Prix = 18.5, Categorie = "Plat principal", CheminImage = "../Photos/Boeuf_Bourguignon.jpg", RestaurantId = 1 },
				new Plat { Id = 2, Nom = "Soupe à l'oignon", Prix = 7.5, Categorie = "Entrée", CheminImage = "../Photos/Soupe_Oignon.jpg", RestaurantId = 1 },

				new Plat { Id = 3, Nom = "Lasagnes maison", Prix = 14.0, Categorie = "Plat principal", CheminImage = "../Photos/Lasagne.jpg", RestaurantId = 3 },
				new Plat { Id = 4, Nom = "Bruschetta", Prix = 6.0, Categorie = "Entrée", CheminImage = "../Photos/Bruschetta.jpg", RestaurantId = 3 },

				new Plat { Id = 5, Nom = "Pizza Margherita", Prix = 12.0, Categorie = "Plat principal", CheminImage = "../Photos/Pizza_Margherita.jpg", RestaurantId = 4 },
				new Plat { Id = 6, Nom = "Tiramisu", Prix = 6.5, Categorie = "Dessert", CheminImage = "../Photos/Tiramisu.jpg", RestaurantId = 4 },

				new Plat { Id = 7, Nom = "Sushi Saumon", Prix = 16.0, Categorie = "Plat principal", CheminImage = "../Photos/Sushi.jpg", RestaurantId = 5 },
				new Plat { Id = 8, Nom = "Soupe Miso", Prix = 4.5, Categorie = "Entrée", CheminImage = "../Photos/Soupe_Miso.jpg", RestaurantId = 5 },

				new Plat { Id = 9, Nom = "Ramen Tonkotsu", Prix = 15.0, Categorie = "Plat principal", CheminImage = "../Photos/Ramen.jpg", RestaurantId = 6 },
				new Plat { Id = 10, Nom = "Mochi", Prix = 5.0, Categorie = "Dessert", CheminImage = "../Photos/Mochi.jpg", RestaurantId = 6 },

				new Plat { Id = 11, Nom = "Tacos Bœuf", Prix = 10.0, Categorie = "Plat principal", CheminImage = "../Photos/Tacos.jpg", RestaurantId = 7 },
				new Plat { Id = 12, Nom = "Guacamole", Prix = 6.0, Categorie = "Entrée", CheminImage = "../Photos/Guacamole.jpg", RestaurantId = 7 },

				new Plat { Id = 13, Nom = "Quesadillas", Prix = 9.5, Categorie = "Plat principal", CheminImage = "../Photos/Quesadillas.jpg", RestaurantId = 8 },
				new Plat { Id = 14, Nom = "Churros", Prix = 5.5, Categorie = "Dessert", CheminImage = "../Photos/Churros.jpg", RestaurantId = 8 },

				new Plat { Id = 15, Nom = "Salade César", Prix = 11.0, Categorie = "Salade", CheminImage = "../Photos/Salade_Cesar.jpg", RestaurantId = 2 },
				new Plat { Id = 16, Nom = "Steak Frites", Prix = 17.0, Categorie = "Plat principal", CheminImage = "../Photos/Steak_Frites.jpg", RestaurantId = 2 },

				new Plat { Id = 17, Nom = "Cheesecake", Prix = 6.5, Categorie = "Dessert", CheminImage = "../Photos/Cheesecake.jpg", RestaurantId = 1 },
				new Plat { Id = 18, Nom = "Tempura de légumes", Prix = 8.0, Categorie = "Entrée", CheminImage = "../Photos/Tempura_de_legumes.jpg", RestaurantId = 5 },

				new Plat { Id = 19, Nom = "Salade de quinoa", Prix = 9.0, Categorie = "Salade", CheminImage = "../Photos/Salade_de_quinoa.jpg", RestaurantId = 6 },
				new Plat { Id = 20, Nom = "Fondant au chocolat", Prix = 7.0, Categorie = "Dessert", CheminImage = "../Photos/Fondant_au_chocolat.jpg", RestaurantId = 2 }
			];

        public List<Plat> GetAllPlats()
        {
			return ListePlat;
		}

		public List<Plat> GetPlatsTop3()
		{
			return ListePlat.OrderBy(p => p.Prix).Take(3).ToList();
		}

		public List<Plat> GetPlatsByResto(int RestoId)
		{
			return ListePlat.Where(a => a.RestaurantId == RestoId).ToList();
		}

		public List<String> GetAllCateg()
		{
			return ListePlat.Select(p => p.Categorie).Distinct().ToList();
		}
    }
}
