using System;
using System.Collections.Generic;
using System.Text;
using MeiditationActivity.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace MeiditationActivity.Data
{
	public class ApplicationDbContext : IdentityDbContext
	{
		public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
			: base(options)
		{
		}
		public DbSet<ApplicationUser> ApplicationUsers { get; set; }
		public DbSet<RangeMeter> RangeMeters { get; set; }
	}
}
