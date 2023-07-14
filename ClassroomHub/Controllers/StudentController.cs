using AutoMapper;
using ClassroomHub.Core.Contracts.Services;
using ClassroomHub.Core.Entities;
using ClassroomHub.Web.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace ClassroomHub.Web.Controllers
{
    public class StudentController : Controller
    {
        private readonly IStudentService _studentService;
        private readonly IMapper _mapper;
        public StudentController(IStudentService studentService, IMapper mapper)
        {
            _studentService = studentService;
            _mapper = mapper;
        }
        public IActionResult Index()
        {
            var students = _studentService.GetAll();
            var studentViewModels = _mapper.Map<List<StudentViewModel>>(students);
            return View(studentViewModels);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(StudentViewModel model)
        {
            _studentService.Add(_mapper.Map<Student>(model));
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult GetById(int id) {
          
            return Ok();
        }
    }
}
