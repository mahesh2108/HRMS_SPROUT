using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using HRMS.Models;
using System.Data;

namespace HRMS.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        List<Employee> _oEmployees = new List<Employee>() {
        new Employee(){Name="mahesh",BirthDate= DateTime.Now,TIN="123",EmployeeType="Regular"},
        new Employee(){Name="chandra",BirthDate= DateTime.Now,TIN="111",EmployeeType="Contract",Salary=1200.00}

        };



        [HttpGet]
        public JsonResult Get()
        {
            return new JsonResult(_oEmployees);
        }

        [HttpPost]
        public JsonResult Post(Employee emp)
        {

            _oEmployees.Add(emp);

            return new JsonResult("Employee Added Successfully..");

        }

    }
}
