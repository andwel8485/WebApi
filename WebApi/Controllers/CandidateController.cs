using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ApplicationCore.Contracts.Services;
using ApplicationCore.Entities;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    public class CandidateController : ControllerBase
    {


        private readonly ICandidateService _cs;
        // GET: api/values
        public CandidateController(ICandidateService candidateService)
        {
            _cs = candidateService;
        }
        [HttpGet]
        public IActionResult GetAll()
        {
            
            List<Candidate> candidates  = _cs.GetAllCandidate().ToList();
            return Ok(candidates);
            
        }

        // GET api/values/5
        [HttpGet]
        [Route("GetById")]
        public IActionResult GetById(int id)
        {
           
            var result = _cs.GetCandidateById(id);

            if (result != null)
            {
                return Ok(result);
            }
            return NotFound();
            
        }

        // POST api/values
        [HttpPost]
        public IActionResult Insert(string firstName, string lastName, string email, string resumeUrl)
        {
            
            var candidate = new Candidate { FirstName = firstName, LastName=lastName, Email=email, ResumeURL=resumeUrl};

            _cs.InsertCandidate(candidate);
            return Ok(candidate);
            
        }


        // PUT api/values/5
        [HttpPut("{id}")]
        public IActionResult Update(int id, string firstName, string middleName, string lastName, string email, string resumeUrl)
        {
            
            var candidate = _cs.GetCandidateById(id);
            if (candidate == null)
            {
                return NotFound();
            }
            candidate.FirstName = firstName;
            candidate.LastName = lastName;
            candidate.MiddleName = middleName;
            candidate.Email = email;
            candidate.ResumeURL = resumeUrl;

            _cs.UpdateCandidate(candidate);
            return Ok(candidate);

        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            
            var result = _cs.GetCandidateById(id);
            if (result == null)
            {
                return NotFound();
            }
            _cs.DeleteCandidate(id);
            return Ok(result);
            


        }
    }
}

