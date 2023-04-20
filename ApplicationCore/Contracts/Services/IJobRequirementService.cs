using System;
using ApplicationCore.Entities;

namespace ApplicationCore.Contracts.Services
{
	public interface IJobRequirementService
	{
        IEnumerable<JobRequirement> GetAllJobRequirement();
        JobRequirement? GetJobRequirementById(int id);
        int DeleteJobRequirement(int id);
        int UpdateJobRequirement(JobRequirement c);
        int InsertJobRequirement(JobRequirement c);
    }
}

