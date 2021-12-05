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
    public class CourseController : Controller
    {
        // GET: Course
        public ActionResult Index()
        {
            CourseListingViewModel viewModel = new CourseListingViewModel();
            viewModel.Courses = CourseService.Instance.AllCoursesInfo();
            return View(viewModel);
        }

        
        public ActionResult Create()
        {
            CourseViewModelCreate viewModel = new CourseViewModelCreate();
            viewModel.departments = DepartmentService.Instance.AllDepartmentsInfo();
            viewModel.Semesters = Enum.GetValues(typeof(Semester)).Cast<Semester>().ToList();
            return View(viewModel);
        }

        [HttpPost]
        public ActionResult Create(CourseViewModelCreate viewModel)
        {
            Course newCourse = new Course();

            newCourse.Code = viewModel.Code;
            newCourse.Name = viewModel.Name;
            newCourse.Credit = viewModel.Credit;
            newCourse.Description = viewModel.Description;

            newCourse.DepartmentId = viewModel.DepartmentId;
            newCourse.Semester = (Semester)Enum.Parse(typeof(Semester),viewModel.Semester.ToString());


            CourseService.Instance.SaveCourse(newCourse);
            return RedirectToAction("Index");
        }

    }
}