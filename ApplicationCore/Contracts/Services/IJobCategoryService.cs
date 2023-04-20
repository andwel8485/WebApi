using System;
using ApplicationCore.Entities;
namespace ApplicationCore.Contracts.Services
{
    public interface IJobCategoryService
    {
        IEnumerable<JobCategory> GetAllJobCategory();
        JobCategory? GetJobCategoryById(int id);
        int DeleteJobCategory(int id);
        int UpdateJobCategory(JobCategory c);
        int InsertJobCategory(JobCategory c);
    }
}

