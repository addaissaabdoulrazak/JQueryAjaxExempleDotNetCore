using JQueryAjaxExemple.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace JQueryAjaxExemple.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public int Add(int number1, int number2)
        {
            return number1 + number2;
        }

        public Number Calculatrice(int number1, int number2)
        {
            Number numbers = new Number();
            numbers.Addition = number1 + number2;
            numbers.Soustraction = number1 - number2;
            numbers.Multiplication = number1 * number2;
            numbers.Division = (Decimal)number1 / number2;
            return numbers;
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
