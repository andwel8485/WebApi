using System;
using ApplicationCore.Contracts.Repositories;
using ApplicationCore.Entities;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
namespace Infrastructure.Repositories
{
	public class JobCategoryRepository:BaseRepository<JobCategory>, IJobCategoryRepository
	{
		public JobCategoryRepository(WebAppDbContext context) : base(context)
        {
		}
	}
}

