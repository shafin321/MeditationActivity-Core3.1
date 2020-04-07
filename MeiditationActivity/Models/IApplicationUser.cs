using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MeiditationActivity.Models
{
	public interface IApplicationUser
	{
		IEnumerable<ApplicationUser> GetAll();

		ApplicationUser GetById(string id);
	}
}
