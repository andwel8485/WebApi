using System;
using ApplicationCore.Contracts.Services;
using ApplicationCore.Contracts.Repositories;
using Infrastructure.Repositories;
using ApplicationCore.Entities;
namespace Infrastructure.Services
{
	public class EmployeeTypeService:IEmployeeTypeService
	{
        private readonly IEmployeeTypeRepository _Repo;
        public EmployeeTypeService(IEmployeeTypeRepository employeeTypeRepository)
        {
            _Repo = employeeTypeRepository;

        }

        public IEnumerable<EmployeeType> GetAllEmployeeType()
        {
            return _Repo.GetAll();
        }
        public EmployeeType? GetEmployeeTypeById(int id)
        {
            return _Repo.GetById(id);
        }
        public int DeleteEmployeeType(int id)
        {
            return _Repo.Delete(id);
        }
        public int UpdateEmployeeType(EmployeeType e)
        {
            return _Repo.Update(e);
        }
        public int InsertEmployeeType(EmployeeType e)
        {
            return _Repo.Insert(e);
        }
    }
}


