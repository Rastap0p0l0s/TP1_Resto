using TP1_Resto.Models;
using TP1_Resto.Services;

namespace TP1_Resto.ViewModels.Plats
{
    public class PlatVM
    {
        private PlatsServices platsServices;

        public List<Plat> plats;
        public List<String> categories;
        public String? selectedCategory;

        public PlatVM()
        {
            platsServices = new PlatsServices();
            plats = platsServices.GetAllPlats();
            categories = platsServices.GetAllCateg();
            selectedCategory = null;
        }

        public PlatVM(String categorie)
        {
            platsServices = new PlatsServices();
            plats = platsServices.GetPlatsByCategorie(categorie);
            categories = platsServices.GetAllCateg();
            selectedCategory = categorie;
        }
    }
}
