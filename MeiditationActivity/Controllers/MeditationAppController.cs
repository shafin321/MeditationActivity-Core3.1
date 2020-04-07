using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MeiditationActivity.Data;
using MeiditationActivity.Models;
using MeiditationActivity.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace MeiditationActivity.Controllers
{
    public class MeditationAppController : Controller
    {
		public static UserManager<ApplicationUser> _userMnager;
		private readonly ApplicationDbContext _context;
		public MeditationAppController(ApplicationDbContext context, UserManager<ApplicationUser> userManager)
		{
			_context = context;
			_userMnager = userManager;
		}

		[Authorize]
		public async Task<IActionResult> Create()
		{
			// post = _context.Ranges.Include(r => r.User);

			/*var range = _context.Ranges.Select(rangeMeter=> new CreateRangeViewModel
			{
				Id= rangeMeter.Id,
				UserId=user.Id,
				Name=User.Identity.Name,
				PhysicalLoad=rangeMeter.PhysicalLoad,
				PhysicalStatusRate=rangeMeter.PhysicalStatusRate,
				MentalStausRate=rangeMeter.MentalStausRate,
				sleepingHour=rangeMeter.sleepingHour,
				SleepQuality=rangeMeter.SleepQuality,
				weight=rangeMeter.weight,
			}
				); */




			return View();
		}

		[HttpPost]
		public async Task<IActionResult> Create(CreateRangeViewModel model)
		{

			//var userId = _userMnager.GetUserId(User);
			//var user = _userMnager.FindByIdAsync(userId);
			//var claimIdenttiy = (ClaimsIdentity)this.User.Identity;
			//var claim = claimIdenttiy.FindFirst(ClaimTypes.NameIdentifier);
			//model.UserId = claim.Value;

			//var claimUser = _context.Ranges.Where(r => r.UserId == model.UserId).FirstOrDefault();
			var user = await _userMnager.FindByNameAsync(User.Identity.Name);
			var currentDate = DateTime.Now;

			RangeMeter newRange = new RangeMeter
			{
				Created = currentDate,
				MentalStausRate = model.MentalStausRate,
				PhysicalLoad = model.PhysicalLoad,
				PhysicalStatusRate = model.PhysicalStatusRate,
				sleepingHour = model.sleepingHour,
				SleepQuality = model.SleepQuality,
				User = user,
				UserId = user.Id


			};
			_context.RangeMeters.Add(newRange);
			_context.SaveChanges();
			return RedirectToAction("Index");
		}

		public IActionResult Index()
		{
			var model = _context.RangeMeters;


			return View();
		}


		[HttpGet]
		public IActionResult GetAll()

		{
			return Json(new { data = _context.RangeMeters });
		}



	}
}
