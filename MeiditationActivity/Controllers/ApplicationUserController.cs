using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MeiditationActivity.Data;
using MeiditationActivity.Models;
using MeiditationActivity.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace MeiditationActivity.Controllers
{
	public class ApplicationUserController : Controller
	{
		private readonly ApplicationDbContext _context;
		private readonly IApplicationUser _userService;
		private readonly UserManager<ApplicationUser> _userManaer;
		public ApplicationUserController(IApplicationUser userService, UserManager<ApplicationUser> userManaer, ApplicationDbContext context)
		{
			_context = context;
			_userManaer = userManaer;
			_userService = userService;

		}
		public IActionResult Index()
		{
			var model = _userService.GetAll();


			return View(model);
		}

		public IActionResult Detail(int id)
		{
			var model = _context.RangeMeters.Find(id);
			//var user = _userManaer.GetUserId();
		//	var user = _userManaer.FindByNameAsync(User.Identity.Name);
		;


			var veiwModel = new UserDetailViewModel
			{
			 
				Id= model.Id,
				PhysicalLoad=model.PhysicalLoad,
				SleepQuality=model.SleepQuality,
				User=model.User,
				UserId=model.UserId,
				
				
				

			};

			return View(veiwModel);


		}
	}
}