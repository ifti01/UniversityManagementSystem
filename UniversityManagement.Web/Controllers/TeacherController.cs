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
    public class TeacherController : Controller
    {
        // GET: Teacher
        public ActionResult Index()
        {
            TeacherListingViewModel viewModel = new TeacherListingViewModel();
            viewModel.Teachers = TeacherService.Instance.AllTeachersInfo();
            return View(viewModel);
        }

        public ActionResult Create()
        {
            TeacherViewModel viewModel = new TeacherViewModel();

            viewModel.departments = DepartmentService.Instance.AllDepartmentsInfo();
            viewModel.designations = DesignationService.Instance.AllDesignationInfo();

            
            return View(viewModel);
        }

        [HttpPost]
        public ActionResult Create(TeacherViewModel viewModel)
        {
            Teacher newTeacher = new Teacher();

            newTeacher.Name = viewModel.Name;
            newTeacher.Address = viewModel.Address;
            newTeacher.Email = viewModel.Email;
            newTeacher.ContactNo = viewModel.ContactNo;

            newTeacher.DepartmentId = viewModel.DepartmentId;
            newTeacher.DesignationId =viewModel.DesignationId;
            
            newTeacher.Credit = viewModel.Credit;
            
            TeacherService.Instance.SaveTeacher(newTeacher);
            return RedirectToAction("Index");
        }
    }
}