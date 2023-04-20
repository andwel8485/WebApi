using ApplicationCore.Entities;
using System;
namespace ApplicationCore.Contracts.Services
{
	public interface IEmployeeTypeService
	{
        IEnumerable<EmployeeType> GetAllEmployeeType();
        EmployeeType? GetEmployeeTypeById(int id);
        int DeleteEmployeeType(int id);
        int UpdateEmployeeType(EmployeeType c);
        int InsertEmployeeType(EmployeeType c);
    }
}

