using Microsoft.AspNetCore.Mvc;

namespace ams.Controllers
{
    public class ProfessorController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult MarkAttendance()
        {
            return View();
        }

        public IActionResult ViewAttendance()
        {
            return View();
        }

        public IActionResult Schedule()
        {
            return View();
        }
        public IActionResult Courses()
        {
            return View();
        }
    }
}
