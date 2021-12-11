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
    public class CourseAssignController : Controller
    {
        // GET: CourseAssign
        public ActionResult Index()
        {
            CourseAssignListingViewModel viewModel = new CourseAssignListingViewModel();
            viewModel.courseassigns = CourseAssignService.Instance.AllAssignCoursesInfo();
            return View(viewModel);
        }

        public ActionResult Create()
        {
            CourseAssignViewModel viewModel = new CourseAssignViewModel();

            viewModel.departments = DepartmentService.Instance.AllDepartmentsInfo();
            viewModel.teachers = TeacherService.Instance.AllTeachersInfo();
            viewModel.courses = CourseService.Instance.AllCoursesInfo();


            return View(viewModel);
        }

        [HttpPost]
        public ActionResult Create(CourseAssignViewModel viewModel)
        {
            CourseAssign newcourseassign = new CourseAssign();

            newcourseassign.DepartmentId = viewModel.DepartmentId;
            newcourseassign.TeacherId = viewModel.TeacherId;

            newcourseassign.Teacher.Credit = viewModel.Teacher.Credit;
            newcourseassign.RemainCredit = viewModel.Teacher.Credit - viewModel.Course.Credit;

            newcourseassign.CourseId = viewModel.CourseId;
            newcourseassign.Course.Name = viewModel.Course.Name;
            newcourseassign.Credit = newcourseassign.Credit;


            CourseAssignService.Instance.SaveCourse(newcourseassign);
            return RedirectToAction("Index");

        }
    }
}