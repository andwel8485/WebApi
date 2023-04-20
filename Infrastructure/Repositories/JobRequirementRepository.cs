using System;
using ApplicationCore.Contracts.Repositories;
using ApplicationCore.Entities;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
namespace Infrastructure.Repositories
{
	public class JobRequirementRepository: BaseRepository<JobRequirement>, IJobRequirementRepository
    {
		public JobRequirementRepository(WebAppDbContext context) : base(context)
        {
		}
	}
}

