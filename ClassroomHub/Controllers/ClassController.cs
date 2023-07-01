using AutoMapper;
using ClassroomHub.Core.Contracts.Services;
using ClassroomHub.Web.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Collections;
using System.Collections.Generic;
using ClassroomHub.Core.Entities;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace ClassroomHub.Web.Controllers
{
    public class ClassController : Controller
    {
        private readonly IClassService _classService;
        private readonly ICourseService _courseService;
        private readonly IMapper _mapper;
     
        public ClassController(IClassService classService, IMapper mapper, ICourseService courseService)
        {
            _classService = classService;
            _mapper = mapper;
            _courseService = courseService;
        }
        public IActionResult Index()
        {
            var courses = _mapper.Map<List<CourseViewModel>>(_courseService.GetAll());
            ViewBag.Courses = new SelectList(courses, "Id", "Name");
            var classes = _classService.GetAll();
            var classesViewModel = _mapper.Map<IEnumerable<ClassViewModel>>(classes);
            return View(classesViewModel);

        }
        public IActionResult Create(ClassViewModel model) {
       
            var classEntity = _mapper.Map<Class>(model);
            _classService.Add(classEntity);
            return RedirectToAction(nameof(Index));
        }

    }

}
