using System;
using ApplicationCore.Entities;

namespace ApplicationCore.Contracts.Services
{
	public interface IStatusService
	{
        IEnumerable<Status> GetAllStatus();
        Status? GetStatusById(int id);
        int DeleteStatus(int id);
        int UpdateStatus(Status c);
        int InsertStatus(Status c);
    }
}

