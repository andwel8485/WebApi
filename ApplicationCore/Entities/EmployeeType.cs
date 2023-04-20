using System;
namespace ApplicationCore.Entities
{
	public class EmployeeType
	{
        public int Id { get; set; }
        public string TypeName { get; set; }

        public List<EmployeeRequirementType> EmployeeRequirementTypes { get; set; }
    }
}

