using Cybersecurity.Application.Services;
using Microsoft.AspNetCore.Mvc;
using Cybersecurity.Application;
using Cybersecurity.Application.User;

namespace Cybersecurity.MVC.Controllers
{
    public class UserController : Controller
    {
        private readonly IUserService userService;

        public UserController(IUserService userService)
        {
            this.userService = userService;
        }

        public async Task<IActionResult> Index()
        {
            var users = await this.userService.GetAll();
            return View(users);
        } 
        
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(UserDto user)
        {
                        
            if (!ModelState.IsValid)
            {
                return View(user);
            }
            await this.userService.Create(user);
            return RedirectToAction(nameof(Create)); //TodoRefractor
        }

        
    }
}
