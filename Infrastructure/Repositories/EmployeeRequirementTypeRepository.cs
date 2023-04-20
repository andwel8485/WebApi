using System;
using ApplicationCore.Contracts.Repositories;
using ApplicationCore.Entities;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
namespace Infrastructure.Repositories
{
	public class EmployeeRequirementTypeRepository:BaseRepository<EmployeeRequirementType>, IEmployeeRequirementTypeRepository
	{
		public EmployeeRequirementTypeRepository(WebAppDbContext context) : base(context)
        {
		}
	}
}

