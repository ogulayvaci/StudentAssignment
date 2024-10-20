using Microsoft.AspNetCore.Mvc;
using BLL.Services;
using BLL.Models;

// Generated from Custom Template.

namespace MVC.Controllers
{
    public class StudentController : Controller
    {
        private readonly IStudentService _studentService;

        public StudentController(IStudentService studentService)
        {
            _studentService = studentService;
        }

        public ActionResult Index()
        {
            var list = _studentService.Query().ToList();
            return View(list);
        }

        public IActionResult Details(int id)
        {
            var student = _studentService.Query().SingleOrDefault(s => s.Record.id == id);

            if (student == null)
                return NotFound();

            return View(student);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost, ValidateAntiForgeryToken]
        public IActionResult Create(StudentModel student)
        {
            if (ModelState.IsValid)
            {
                var result = _studentService.Create(student.Record);
                if (result.IsSuccessful)
                    return RedirectToAction(nameof(Index));
            }

            return View(student);
        }
    }
}
