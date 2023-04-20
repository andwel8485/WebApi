using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApplicationCore.Contracts.Services;
using ApplicationCore.Entities;
using Infrastructure.Services;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    public class JobCategoryController : ControllerBase
    {
        // GET: api/values
        private readonly IJobCategoryService _js;

        public JobCategoryController(IJobCategoryService jobCategoryService)
        {
            _js = jobCategoryService;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
           
            List<JobCategory> jobCategories = _js.GetAllJobCategory().ToList();
            return Ok(jobCategories);
            
            
        }

        // GET api/values/5
        [HttpGet]
        [Route("GetById")]
        public IActionResult GetById(int id)
        {
            var result = _js.GetJobCategoryById(id);
   
            if (result != null)
            {
                return Ok(result);
            }
            return NotFound();
                 
        }

        // POST api/values
        [HttpPost]
        public IActionResult Insert(string name)
        {
       
            var jobCategory = new JobCategory { Name = name };

            _js.InsertJobCategory(jobCategory);
            return Ok(jobCategory);
           
        }


        // PUT api/values/5
        [HttpPut("{id}")]
        public IActionResult Update(int id, string name)
        {
           
            var jobCategory = _js.GetJobCategoryById(id);
            if (jobCategory == null)
            {
                return NotFound();
            }
            jobCategory.Name = name;

            _js.UpdateJobCategory(jobCategory);
            return Ok(jobCategory);
            
            
            

        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
           
            var result = _js.GetJobCategoryById(id);
            if (result == null)
            {
                return NotFound();
            }
            _js.DeleteJobCategory(id);
            return Ok(result);
            
            
            
        }
    }
}

