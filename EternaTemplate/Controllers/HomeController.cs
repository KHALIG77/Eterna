using EternaTemplate.Data_Access;
using EternaTemplate.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace EternaTemplate.Controllers
{
	public class HomeController:Controller
	{
		public ActionResult Index() { 
			HomeModel homeModel = new HomeModel();
			homeModel.Features = Data.features;
			homeModel.Services = Data.services;

			return View(homeModel);
		}	
		public ActionResult About()
		{
			return View();
		}
		public ActionResult Contact()
		{
			return View();
		}
	}
}
