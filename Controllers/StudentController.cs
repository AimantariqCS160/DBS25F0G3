using Microsoft.AspNetCore.Mvc;

namespace ams.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Attendance()
        {
            return View();
        }

        public IActionResult CourseEnrollement()
        {
            return View();
        }
        public IActionResult TimeTable()
        {
            return View();
        }
        public IActionResult Feedback()
        {
            return View();
        }

    }

}
