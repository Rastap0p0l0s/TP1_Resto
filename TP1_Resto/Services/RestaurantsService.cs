using TP1_Resto.Models;

namespace TP1_Resto.Services
{
	public class RestaurantsService
	{
		public List<Restaurant> ListeResto=
			[new Restaurant
				{
					Id = 1,
					Nom = "Le Bistrot du Marché",
					Adresse = "12 rue des Halles",
					Cuisine = "Française",
					Note = 4.5,
					Ville = "Paris"
				},
				new Restaurant
				{
					Id = 2,
					Nom = "Chez Marcel",
					Adresse = "8 place Bellecour",
					Cuisine = "Française",
					Note = 4.2,
					Ville = "Lyon"
				},
				new Restaurant
				{
					Id = 3,
					Nom = "La Dolce Vita",
					Adresse = "25 avenue Jean Médecin",
					Cuisine = "Italienne",
					Note = 4.6,
					Ville = "Nice"
				},
				new Restaurant
				{
					Id = 4,
					Nom = "Trattoria Roma",
					Adresse = "3 rue de la République",
					Cuisine = "Italienne",
					Note = 4.3,
					Ville = "Marseille"
				},
				new Restaurant
				{
					Id = 5,
					Nom = "Sushi Zen",
					Adresse = "14 rue Sainte-Catherine",
					Cuisine = "Japonaise",
					Note = 4.7,
					Ville = "Bordeaux"
				},
				new Restaurant
				{
					Id = 6,
					Nom = "Tokyo Express",
					Adresse = "9 boulevard Wilson",
					Cuisine = "Japonaise",
					Note = 4.1,
					Ville = "Toulouse"
				},
				new Restaurant
				{
					Id = 7,
					Nom = "El Sombrero",
					Adresse = "18 rue Oberkampf",
					Cuisine = "Mexicaine",
					Note = 4.4,
					Ville = "Paris"
				},
				new Restaurant
				{
					Id = 8,
					Nom = "Casa Azteca",
					Adresse = "6 cours Mirabeau",
					Cuisine = "Mexicaine",
					Note = 4.0,
					Ville = "Aix-en-Provence"
				}];

		public List<Restaurant> GetAllResto()
		{
			return ListeResto;
		}

		public List<Restaurant> GetRestoTop3()
		{
			return ListeResto.OrderByDescending(r => r.Note).Take(3).ToList();
		}

		public List<Restaurant> GetRestaurantsInAlphabeticalOrder()
		{
			return ListeResto.OrderBy(r => r.Nom).ToList();
		}
	}
}
