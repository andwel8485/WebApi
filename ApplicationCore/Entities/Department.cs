using System;
using ApplicationCore.Entities;
namespace ApplicationCore.Entities
{
	public class Department
	{
		public int Id { get; set; }
		public string DepartmentName  { get; set; }
		public string Location { get; set; }
		public List<Employee> Employees { get; set; }
	}
}

