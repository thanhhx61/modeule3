using BookStore.Services;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Services;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        private readonly IStudentService studentService;
        private readonly IWebHostEnvironment webHostEnvironment;
        private readonly IClasssService classsService;

        public HomeController(IStudentService studentService,
                        IWebHostEnvironment webHostEnvironment,
                        IClasssService classsService)
        {
            this.studentService = studentService;
            this.webHostEnvironment = webHostEnvironment;
            this.classsService = classsService;
        }
        public IActionResult Index()
        {
            return View("~/Views/Home/Index.cshtml", studentService.GetStudents());
        }

        public IActionResult Detail(int id)
        {
            var student = studentService.GetStudent(id);
            return View(student);
        }

        
    }
}
