using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DotNetCoreApplication.Entities
{
    public class Employee
    {
        [Key]
        public int EmployeeId { get; set; }

        public string EmployeeName { get; set; }

        public string EmployeeCode { get; set; }

        public string ContactNo { get; set; }

        public string CompanyName { get; set; }

        public DateTime CreatedOn { get; set; } 
    }
}
