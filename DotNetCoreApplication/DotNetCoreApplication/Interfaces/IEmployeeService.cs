using DotNetCoreApplication.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotNetCoreApplication.Interfaces
{
    public interface IEmployeeService : IDisposable
    {
        int Delete(int EmployeeId);
        Employee GetEmployeeById(int EmployeeId);
        string Update(Employee employee);
        int Create(Employee employee);
        List<Employee> GetAll();
    }
}
