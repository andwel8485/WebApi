using System;
using ApplicationCore.Contracts.Repositories;
using ApplicationCore.Entities;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
namespace Infrastructure.Repositories
{
	public class SubmissionRepository: BaseRepository<Submission>, ISubmissionRepository
    {
		public SubmissionRepository(WebAppDbContext context) : base(context)
        {
		}
	}
}

