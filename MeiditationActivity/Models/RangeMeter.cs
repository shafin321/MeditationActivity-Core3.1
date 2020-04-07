using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MeiditationActivity.Models
{
	public class RangeMeter
	{
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
		[DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
		public DateTime Created { get; set; }
	}
}
