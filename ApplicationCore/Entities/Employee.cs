using System;
namespace ApplicationCore.Entities
{
	public class Employee
	{
		public int Id { get; set; }
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public decimal Salary { get; set; }

        // navigation property: used to help reference values from related table
        public Department Department { get; set; }

    }
}

