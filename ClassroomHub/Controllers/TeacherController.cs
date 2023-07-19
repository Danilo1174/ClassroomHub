using AutoMapper;
using ClassroomHub.Core.Contracts.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using ClassroomHub.Web.ViewModels;

namespace ClassroomHub.Web.Controllers
{
	public class TeacherController : Controller
	{
		private readonly ITeacherService _teacherService;
		private readonly IMapper _mapper;

		public TeacherController(ITeacherService teacherService, IMapper mapper)
		{
			_teacherService = teacherService;
			_mapper = mapper;
		}


		
		public ActionResult Index()
		{
			var teachers = _teacherService.GetAll();
			var teacherViewModel = _mapper.Map<IEnumerable<TeacherViewModel>>(teachers);
			return View(teacherViewModel);
		}

		
		public ActionResult Details(int id)
		{
			return View();
		}

		
		public ActionResult Create()
		{
			return View();
		}

		
		[HttpPost]
		[ValidateAntiForgeryToken]
		public ActionResult Create(IFormCollection collection)
		{
			try
			{
				return RedirectToAction(nameof(Index));
			}
			catch
			{
				return View();
			}
		}

		
		public ActionResult Edit(int id)
		{
			return View();
		}

	
		[HttpPost]
		[ValidateAntiForgeryToken]
		public ActionResult Edit(int id, IFormCollection collection)
		{
			try
			{
				return RedirectToAction(nameof(Index));
			}
			catch
			{
				return View();
			}
		}

	
		public ActionResult Delete(int id)
		{
			return View();
		}

	
		[HttpPost]
		[ValidateAntiForgeryToken]
		public ActionResult Delete(int id, IFormCollection collection)
		{
			try
			{
				return RedirectToAction(nameof(Index));
			}
			catch
			{
				return View();
			}
		}
	}
}
