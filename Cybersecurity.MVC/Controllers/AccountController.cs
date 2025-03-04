using Cybersecurity.Application.Services;
using Microsoft.AspNetCore.Mvc;
using Cybersecurity.Application;
using Cybersecurity.Application.User;
using Cybersecurity.MVC.Models;
using Cybersecurity.Domain.Interfaces;
using Cybersecurity.Domain.Entities;


namespace Cybersecurity.MVC.Controllers
{
    public class AccountController : Controller
    {
        private IUserRepository _userRepository;
        public AccountController(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }
        public ActionResult Login()
        {
            return View();
        }
        public ActionResult CreateAccount()
        {
            return RedirectToAction("Login", "Account");
        }
        [HttpPost]
        public ActionResult LogMeIn([FromBody]LoginModel model)
        {
            User user = _userRepository.FindUserByCredentials(model.UserName, model.Password);
            return RedirectToAction("Index", "Home");
            
        }
    }
}
