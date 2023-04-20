using System;
using ApplicationCore.Contracts.Repositories;
using ApplicationCore.Entities;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
namespace Infrastructure.Repositories
{
	public class CandidateRepository:BaseRepository<Candidate>, ICandidateRepository
	{
		public CandidateRepository(WebAppDbContext context):base(context)
		{
		}
	}
}

