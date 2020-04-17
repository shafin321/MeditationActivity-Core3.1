using MeiditationActivity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MeiditationActivity.ViewModels
{
	public class IndexModel
	{
		public IEnumerable<RangeMeter> RangeMeterList { get; set; }

		public ApplicationUser ApplicationUser { get; set; }
	}
}
