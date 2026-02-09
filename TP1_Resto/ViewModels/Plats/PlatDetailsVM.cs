using TP1_Resto.Models;
using TP1_Resto.Services;

namespace TP1_Resto.ViewModels.Plats
{
    public class PlatDetailsVM
    {
		public PlatsServices platsServices;
		public Plat plat;
		
		public PlatDetailsVM(int Id)
		{
			platsServices = new PlatsServices();
			plat = platsServices.GetPlatById(Id);
		}
	}
}
