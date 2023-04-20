using System;
using ApplicationCore.Entities;

namespace ApplicationCore.Contracts.Services
{
	public interface IEmployeeRequirementTypeService
	{
        IEnumerable<EmployeeRequirementType> GetAllEmployeeRequirementType();
        EmployeeRequirementType? GetEmployeeRequirementTypeById(int id);
        int DeleteEmployeeRequirementType(int id);
        int UpdateEmployeeRequirementType(EmployeeRequirementType c);
        int InsertEmployeeRequirementType(EmployeeRequirementType c);
    }
}

