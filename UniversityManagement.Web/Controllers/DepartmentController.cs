using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UniversityManagement.Entities;
using UniversityManagement.Service;
using UniversityManagement.Web.ViewModel;

namespace UniversityManagement.Web.Controllers
{
    public class DepartmentController : Controller
    {
        // GET: Department
        public ActionResult Index()
        {
            DepartmentViewModel viewModel = new DepartmentViewModel();

            viewModel.departments = DepartmentService.Instance.AllDepartmentsInfo();

            return View(viewModel);
        }
        public ActionResult Create()
        {
            return View();
        } 
        [HttpPost]
        public ActionResult Create(Department department)
        {
            Department newDepartment = new Department();
            newDepartment.Code = department.Code;
            newDepartment.Name = department.Name;

            DepartmentService.Instance.SaveDept(newDepartment);
            return RedirectToAction("Index");
        }
    }
}