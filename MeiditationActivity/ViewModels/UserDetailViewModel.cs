using MeiditationActivity.Models;
using Microsoft.Extensions.ObjectPool;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MeiditationActivity.ViewModels
{
	public class UserDetailViewModel
	{
		IEnumerable<RangeMeter> RangeList { get; set; }

		public RangeMeter RangeMeter { get; set; }

		public ApplicationUser ApplicationUser { get; set; }

		public int Id { get; set; }
		public int sleepingHour { get; set; }
		public int PhysicalLoad { get; set; }
		public string SleepQuality { get; set; }
		public double weight { get; set; }
		public int MentalStausRate { get; set; }
		public int PhysicalStatusRate { get; set; }
		public string UserId { get; set; }
		public string Stressed { get; set; }

		[ForeignKey("UserId")]
		public ApplicationUser User { get; set; }


	}
}
