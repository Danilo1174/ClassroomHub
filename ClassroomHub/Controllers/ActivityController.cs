using ClassroomHub.Web.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System;
using System.Linq;
using ClassroomHub.Core.Contracts.Services;

namespace ClassroomHub.Web.Controllers
{
    public class ActivityController : Controller
    {
        List<ActivityToStudentViewModel> activities = new List<ActivityToStudentViewModel>()
        {
   
        };
        private readonly IActivityService _activityService;

        public ActivityController(IActivityService activityService)
        {
            _activityService = activityService;
        }
        public IActionResult Index()
        {

            ViewData["Teacher"] = activities.FirstOrDefault()?.TeacherName ?? "Sem professor";
            ViewData["ModuleName"] = activities.FirstOrDefault()?.ModuleName ?? "Sem modulo";
            return View(activities);
        }


    }
}
