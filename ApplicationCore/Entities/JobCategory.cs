using System;
namespace ApplicationCore.Entities
{
	public class JobCategory
	{
        public int Id { get; set; }
        public string Name { get; set; }
        public List<JobRequirement> JobRequirements { get; set; }
    }
}

