using System.Collections.Generic;
using EternaTemplate.Models;

namespace EternaTemplate.Data_Access
{
	public static class Data
	{
		public static List<Feature> features = new List<Feature>()
		{
			new Feature{Id=1,Icon="bi bi-bar-chart",Title="Title 1",Description="Description1"},
			new Feature{Id=2,Icon="bi bi-card-checklist",Title="Title 2",Description="Description2"},
			new Feature{Id=3,Icon="bi bi-binoculars",Title="Title 3",Description="Description3"}
		};
		public static List<Service> services = new List<Service>()
		{
			new Service{Id=1,Icon="bx bxl-dribbble",Title="Title 1",Description="Description1"},
			new Service{Id=2,Icon="bx bx-file",Title="Title 2",Description="Description2"},
			new Service{Id=3,Icon="bx bx-tachometer",Title="Title 3",Description="Description3"},
			new Service{Id=4,Icon="bx bx-world",Title="Title 4",Description="Description4"},
			new Service{Id=5,Icon="bx bx-slideshow",Title="Title 5",Description="Description5"},
			new Service{Id=6,Icon="bx bx-arch",Title="Title 6",Description="Description6"}
		};

		public static List<Feature> Featureds { get; internal set; }
		public static List<Service> Services { get; internal set; }
	}
}
