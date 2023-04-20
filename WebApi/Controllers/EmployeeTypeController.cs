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
    public class EmployeeTypeController : ControllerBase
    {
        // GET: api/values
        private readonly IEmployeeTypeService _service;
        // GET: api/values
        public EmployeeTypeController(IEmployeeTypeService employeeTypeService)
        {
            _service = employeeTypeService;
        }
        [HttpGet]
        public IActionResult GetAll()
        {
            
            List<EmployeeType> employeeTypes = _service.GetAllEmployeeType().ToList();
            return Ok(employeeTypes);
            

        }

        // GET api/values/5
        [HttpGet]
        [Route("GetById")]
        public IActionResult GetById(int id)
        {
           
            var result = _service.GetEmployeeTypeById(id);

            if (result != null)
            {
                return Ok(result);
            }
            return NotFound();
            

        }

        // POST api/values
        [HttpPost]
        public IActionResult Insert(string typeName)
        {
            
            var employeeType = new EmployeeType { TypeName = typeName };

            _service.InsertEmployeeType(employeeType);
            return Ok(employeeType);

        }


        // PUT api/values/5
        [HttpPut("{id}")]
        public IActionResult Update(int id, string typeName)
        {
         
            var employeeType = _service.GetEmployeeTypeById(id);
            if (employeeType == null)
            {
                return NotFound();
            }
            employeeType.TypeName = typeName;
                

            _service.UpdateEmployeeType(employeeType);
            return Ok(employeeType);
            


        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
           
            var result = _service.GetEmployeeTypeById(id);
            if (result == null)
            {
                return NotFound();
            }
            _service.DeleteEmployeeType(id);
            return Ok(result);
            
        }
    }
}

