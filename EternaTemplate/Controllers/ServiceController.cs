using EternaTemplate.Data_Access;
using EternaTemplate.Models;
using EternaTemplate.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace EternaTemplate.Controllers
{
	public class ServiceController:Controller
	{
		public ActionResult Index()
		{
			ServiceModel servicemodel = new ServiceModel()
			{
				Services = Data.services
			};
			return View(servicemodel);
		}
		public ActionResult Detail(int value) {
			Service da = Data.services.Find(x =>x.Id==value);
			if (da!=null)
			{
                return View(da);
            }
			else
			{
                return View("Error");
            }
			
			
        }
	}
}
