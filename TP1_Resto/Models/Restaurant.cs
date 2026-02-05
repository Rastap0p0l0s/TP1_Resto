using System.ComponentModel.DataAnnotations.Schema;

namespace TP1_Resto.Models
{
    public class Restaurant
    {
        public int Id { get; set; }
        public string Nom { get; set; }
        public string Adresse { get; set; }
        public string Telephone { get; set; }

        //Doit avoir au moins 3 types de cuisine (type de nourriture)
        public string Cuisine {  get; set; }
        public double Note { get; set; }
        public string Ville {  get; set; }

        [NotMapped]
        public int NbrPlats { get; set; }

		public List<Plat> Plats { get; set; }
	}
}
