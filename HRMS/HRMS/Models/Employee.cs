using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HRMS.Models
{
    public class Employee
    {
        public string Name { get; set; }

        public DateTime BirthDate { get; set; }

        public string TIN { get; set; }

        public string EmployeeType { get; set; }

        public double Salary { get; set; }

    }
}
