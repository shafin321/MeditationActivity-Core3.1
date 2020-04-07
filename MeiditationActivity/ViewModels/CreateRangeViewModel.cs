using MeiditationActivity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MeiditationActivity.ViewModels
{
	public class CreateRangeViewModel
	{
		public int Id { get; set; }
		//	public RangeMeter RangeMeter { get; set; }
		public ApplicationUser ApplicationUser { get; set; }
		public string Name { get; set; }
		public string UserId { get; set; }

		public DateTime Created { get; set; }

		public int sleepingHour { get; set; }
		public int PhysicalLoad { get; set; }
		public string SleepQuality { get; set; }
		public double weight { get; set; }
		public int MentalStausRate { get; set; }
		public int PhysicalStatusRate { get; set; }
	}
}
