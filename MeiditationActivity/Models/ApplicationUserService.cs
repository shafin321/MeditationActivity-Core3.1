using MeiditationActivity.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MeiditationActivity.Models
{
	public class ApplicationUserService : IApplicationUser
	{
		private readonly ApplicationDbContext _context;
		public ApplicationUserService(ApplicationDbContext context)
		{
			_context = context;
		}
		public IEnumerable<ApplicationUser> GetAll()
		{
			return _context.ApplicationUsers;
		}

		public ApplicationUser GetById(string id)
		{
			return _context.ApplicationUsers.FirstOrDefault(user => user.Id == id);
		}
	}
}
