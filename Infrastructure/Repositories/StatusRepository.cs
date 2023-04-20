using System;
using ApplicationCore.Contracts.Repositories;
using ApplicationCore.Entities;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
namespace Infrastructure.Repositories
{
	public class StatusRepository: BaseRepository<Status>, IStatusRepository
    {
		public StatusRepository(WebAppDbContext context) : base(context)
        {
		}
	}
}

