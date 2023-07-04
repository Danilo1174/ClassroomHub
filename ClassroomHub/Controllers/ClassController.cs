using AutoMapper;
using ClassroomHub.Core.Contracts.Services;
using ClassroomHub.Web.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Collections;
using System.Collections.Generic;
using ClassroomHub.Core.Entities;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;

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
        [HttpGet]
        public IActionResult Index()
        {
            var courses = _mapper.Map<List<CourseViewModel>>(_courseService.GetAll());
            ViewBag.Courses = new SelectList(courses, "Id", "Name");
            var classes = _classService.GetAll();
            var classesViewModel = _mapper.Map<IEnumerable<ClassViewModel>>(classes);
            return View(classesViewModel);

        }
        [HttpPost]
        public IActionResult Create(ClassViewModel model) {
       
            var classEntity = _mapper.Map<Class>(model);
            _classService.Add(classEntity);
            return RedirectToAction(nameof(Index));
        }

        public IActionResult Edit(Guid id)
        {

            var courses = _mapper.Map<List<CourseViewModel>>(_courseService.GetAll());
            ViewBag.Courses = new SelectList(courses, "Id", "Name");
            

            var classe = _classService.GetById(id);
            var classViewModel = _mapper.Map<ClassViewModel>(classe);
            return View(classViewModel);

        }
        [HttpPost]
        public IActionResult Edit(ClassViewModel model)
        {
            var classEntity = _mapper.Map<Class>(model);
            _classService.Update(classEntity);
            return RedirectToAction(nameof(Index));
        }

        public IActionResult Delete(Guid id)
        {
            _classService.Delete(id);
            return RedirectToAction(nameof(Index));
        }

    }

}
