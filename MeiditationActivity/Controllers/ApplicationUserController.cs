using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MeiditationActivity.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace MeiditationActivity.Controllers
{
	public class ApplicationUserController : Controller
	{
		private readonly IApplicationUser _userService;
		private readonly UserManager<ApplicationUser> _userManaer;
		public ApplicationUserController(IApplicationUser userService, UserManager<ApplicationUser> userManaer)
		{
			_userManaer = userManaer;
			_userService = userService;

		}
		public IActionResult Index()
		{
			var model = _userService.GetAll();


			return View(model);
		}
	}
}