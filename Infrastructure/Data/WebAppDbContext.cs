using System;
using ApplicationCore.Entities;
using Microsoft.EntityFrameworkCore;
namespace Infrastructure.Data
{
	public class WebAppDbContext:DbContext
	{
		public WebAppDbContext(DbContextOptions<WebAppDbContext> option): base(option)
        {
		}

        public DbSet<Candidate> Candidates { get; set; }
        public DbSet<JobRequirement> JobRequirements { get; set; }
        public DbSet<JobCategory> JobCategories { get; set; }
        public DbSet<EmployeeType> EmployeeTypes { get; set; }
        public DbSet<EmployeeRequirementType> EmployeeRequirementTypes { get; set; }
        public DbSet<Submission> Submissions { get; set; }
        public DbSet<Status> Statuses { get; set; }
    }
}

