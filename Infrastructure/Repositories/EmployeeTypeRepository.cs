using System;
using ApplicationCore.Contracts.Repositories;
using ApplicationCore.Entities;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
namespace Infrastructure.Repositories
{
	public class EmployeeTypeRepository: BaseRepository<EmployeeType>, IEmployeeTypeRepository
    {
		public EmployeeTypeRepository(WebAppDbContext context) : base(context)
        {
		}
	}
}

