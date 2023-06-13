using ClassroomHub.Core.Entities;
using ClassroomHub.Web.ViewModels;
using Microsoft.AspNetCore.Mvc;
using AutoMapper;
using ClassroomHub.Core.Contracts.Services;
using System;

namespace ClassroomHub.Web.Controllers
{
    public class UserController : Controller
    {
        private readonly IUserService _userService;
        private readonly IMapper _mapper;

        private User usuario = new User()
        {
            Email = "danilomengo12@gmail.com",
            Password = "teste123"
        } ;
        public UserController(IUserService userService, IMapper mapper)
        {
            _mapper = mapper;
            _userService = userService;
        }
        public IActionResult Index()
        {
            _userService.GetById(new Guid("1481b2af-c2ff-4c84-fcd4-08db6b9c1736"));

            
            return View();
        }

        public IActionResult Create(UserViewModel model)
        {
            var user = _mapper.Map<User>(model);
            _userService.Create(user);
            return Ok();
        }
    }
}
