using Microsoft.AspNetCore.Mvc;

namespace ams.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult ManageProfessor()
        {
            return View();
        }
        public IActionResult AddProfessor()
        {
            return View();
        }
        public IActionResult AssignCourse()
        {
            return View();
        }

        public IActionResult EditProfessor()
        {
            return View();
        }
        public IActionResult ManageStudent()
        {
            return View();
        }
        public IActionResult AddStudent()
        {
            return View();
        }
        public IActionResult EditStudent()
        {
            return View();
        }
        public IActionResult ManageDepartment()
        {
            return View();
        }
        public IActionResult AddDepartment()
        {
            return View();
        }
        public IActionResult ManageCourses()
        {
            return View();
        }
        public IActionResult AddCourse()
        {
            return View();
        }
    }
}
