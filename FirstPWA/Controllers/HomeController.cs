using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using FirstPWA.Models;
using FirstPWA.Services;

namespace FirstPWA.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private IPasswordService _passwordService;

        public HomeController(ILogger<HomeController> logger, IPasswordService passwordService)
        {
            _logger = logger;
            _passwordService = passwordService;
        }

        public IActionResult Index()
        {
            Password password = new Password()
            {
                PasswordString = ""
            };

            return View("Index", password);
        }

        public IActionResult GetPassword(int passwordLength)
        {
            Password password = new Password()
            {
                PasswordString = _passwordService.GeneratePassword(passwordLength)
            };

            return View("Index", password);
        }

        public IActionResult Privacy()
        {
            return View();
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
