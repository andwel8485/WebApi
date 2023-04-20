using System;
namespace ApplicationCore.Entities
{
	public class JobRequirement
	{
        public int Id { get; set; }
        public int NumberOfPosition { get; set; }
        public string? Title { get; set; }
        public string? Description { get; set; }
        public int HiringManagerId { get; set; }
        public string? HiringManagerName { get; set; }
        public DateTime StartDate { get; set; }
        public bool IsActive { get; set; }
        public DateTime? ClosedOn { get; set; }
        public string ClosedReason { get; set; }
        public DateTime CreatedOn { get; set; }
        public int JobCategoryId { get; set; }
        public JobCategory JobCategory { get; set; } //Manager, employee, Lead, Senior, 
        public List<EmployeeRequirementType> EmployeeRequirementType { get; set; } //Parttime, intern, Fulltime
        public List<Submission> Submissions { get; set; }
    }
}

