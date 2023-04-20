using System;
using ApplicationCore.Contracts.Services;
using ApplicationCore.Contracts.Repositories;
using Infrastructure.Repositories;
using ApplicationCore.Entities;

namespace Infrastructure.Services
{
	public class JobCategoryService:IJobCategoryService
	{
        private readonly IJobCategoryRepository _jobcategoryRepo;
        public JobCategoryService(IJobCategoryRepository jobCategoryRepository)
        {
            _jobcategoryRepo = jobCategoryRepository;

        }

        public IEnumerable<JobCategory> GetAllJobCategory()
        {
            return _jobcategoryRepo.GetAll();
        }
        public JobCategory? GetJobCategoryById(int id)
        {
            return _jobcategoryRepo.GetById(id);
        }
        public int DeleteJobCategory(int id)
        {
            return _jobcategoryRepo.Delete(id);
        }
        public int UpdateJobCategory(JobCategory jc)
        {
            return _jobcategoryRepo.Update(jc);
        }
        public int InsertJobCategory(JobCategory jc)
        {
            return _jobcategoryRepo.Insert(jc);
        }
    }
}

