using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DotNetCoreApplication.Entities;
using DotNetCoreApplication.Interfaces;
using DotNetCoreApplication.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;

namespace DotNetCoreApplication.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly IEmployeeService _employeeManager;
        private readonly IHostingEnvironment _hostingEnvironment;

        public EmployeeController(IEmployeeService employeeManager, IHostingEnvironment hostingEnvironment)
        {
            _employeeManager = employeeManager;
            _hostingEnvironment = hostingEnvironment;
        }

        /// <summary>
        /// This action method is used for show employee details
        /// </summary>
        /// <returns></returns>
        public IActionResult Index()
        {
            var data = _employeeManager.GetAll();
            return View(data);
        }

        public ActionResult Add()
        {
            return View("FormEmployee", new EmployeeModel());
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Add(EmployeeModel model)
        {
            if (ModelState.IsValid)
            {
                var employee = new Employee()
                {
                    EmployeeCode = model.EmployeeCode,
                    EmployeeName = model.EmployeeName,
                    CompanyName = model.CompanyName,
                    ContactNo = model.ContactNo,
                    CreatedOn = DateTime.Now
                };

                _employeeManager.Create(employee);
                return RedirectToAction("Index", "Employee");
            }
            return View("FormEmployee", model);
        }



        #region Edit Employee  

        public ActionResult Edit(int EmployeeId)
        {
            var employee = _employeeManager.GetEmployeeById(EmployeeId);
            var employeeModel = new EmployeeModel
            {
                EmployeeCode = employee.EmployeeCode,
                EmployeeName = employee.EmployeeName,
                CompanyName = employee.CompanyName,
                ContactNo = employee.ContactNo,
                CreatedOn = employee.CreatedOn,
                EmployeeId = employee.EmployeeId
            };
            return View("FormEmployee", employeeModel);
        }

        /// <summary>
        /// This action method is used for edit the employee details
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(EmployeeModel model)
        {
            if (ModelState.IsValid)
            {
                var employee = new Employee()
                {
                    EmployeeCode = model.EmployeeCode,
                    EmployeeName = model.EmployeeName,
                    CompanyName = model.CompanyName,
                    ContactNo = model.ContactNo,
                    EmployeeId = model.EmployeeId
                };
                _employeeManager.Update(employee);
                return RedirectToAction("Index", "Employee");
            }
            return View("FormEmployee", model);
        }

        #endregion

        #region Delete Employee  

        public ActionResult Delete(int EmployeeId)
        {
            var result = _employeeManager.Delete(EmployeeId);
            return RedirectToAction("Index", "Employee");
        }

        #endregion


    }
}