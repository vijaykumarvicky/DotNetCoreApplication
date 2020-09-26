using Dapper;
using DotNetCoreApplication.Entities;
using DotNetCoreApplication.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace DotNetCoreApplication.Services
{
    public class EmployeeService : IEmployeeService
    {
        private readonly IDapperHelper _dapperHelper;

        public EmployeeService(IDapperHelper dapperHelper)
        {
            this._dapperHelper = dapperHelper;
        }

        /// <summary>
        /// This method is used for save the employee details
        /// </summary>
        /// <param name="employee"></param>
        /// <returns>employeeId</returns>
        public int Create(Employee employee)
        {
            var dbParameter = new DynamicParameters();
            dbParameter.Add("EmployeeName", employee.EmployeeName, DbType.String);
            dbParameter.Add("EmployeeCode", employee.EmployeeCode, DbType.String);
            dbParameter.Add("ContactNo", employee.ContactNo, DbType.String);
            dbParameter.Add("CompanyName", employee.CompanyName, DbType.String);
            dbParameter.Add("CreatedOn", employee.CreatedOn, DbType.DateTime);
            var result = _dapperHelper.Insert<int>("SP_Employee_Create", dbParameter, commandType: CommandType.StoredProcedure);
            return result;
        }

        /// <summary>
        /// This method is used for delete the employee details
        /// </summary>
        /// <param name="EmployeeId"></param>
        /// <returns></returns>
        public int Delete(int EmployeeId)
        {
            var data = _dapperHelper.Execute($"Delete [Employee] where EmployeeId={EmployeeId}", null, commandType: CommandType.Text);
            return data;
        }

        public void Dispose()
        {

        }

        /// <summary>
        /// This method is used for get all employees
        /// </summary>
        /// <returns>employees</returns>
        public List<Employee> GetAll()
        {
            var employees = _dapperHelper.GetAll<Employee>("SP_Employee_GetAll", null, commandType: CommandType.StoredProcedure);
            return employees.ToList();
        }


        /// <summary>
        /// This method is used for get employee details by id
        /// </summary>
        /// <param name="EmployeeId"></param>
        /// <returns></returns>
        public Employee GetEmployeeById(int EmployeeId)
        {
            var dbParameter = new DynamicParameters();
            dbParameter.Add("EmployeeId", EmployeeId, DbType.String);
            var result = _dapperHelper.Get<Employee>("SP_Employee_GetbyId", dbParameter, commandType: CommandType.StoredProcedure);
            return result;
        }

        /// <summary>
        /// This method is used for update employee details
        /// </summary>
        /// <param name="employee"></param>
        /// <returns></returns>
        public string Update(Employee employee)
        {
            var dbParameter = new DynamicParameters();
            dbParameter.Add("EmployeeId", employee.EmployeeId, DbType.Int32);
            dbParameter.Add("EmployeeName", employee.EmployeeName, DbType.String);
            dbParameter.Add("EmployeeCode", employee.EmployeeCode, DbType.String);
            dbParameter.Add("ContactNo", employee.ContactNo, DbType.String);
            dbParameter.Add("CompanyName", employee.CompanyName, DbType.String);
            var result = _dapperHelper.Update<string>("SP_Employee_Update", dbParameter, commandType: CommandType.StoredProcedure);
            return result;
        }
    }
}
