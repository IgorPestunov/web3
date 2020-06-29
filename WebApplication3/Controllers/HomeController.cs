using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using WebApplication3.Models;

namespace WebApplication3.Controllers
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
        [HttpGet]
        public IActionResult Quiz()
        {
            QCreate quiz = new QCreate();
            quiz.Generate();
            return View(quiz);
        }

        [HttpPost]
       public IActionResult Quiz(QCreate quiz, string action, int Useranswer)
        {
            
            if (!ModelState.IsValid) return View(quiz);
            Qquest quest = new Qquest();
            if (action == "Next")
            {                
                quest.answer = Useranswer;
                quiz.Generate();
                quest.number1 = quiz.num1;
                quest.number2 = quiz.num2;
                quest.oper = quiz.operat;
                quest.count();
                quiz.Expressions.Add(quest);
                return View(quiz);
            }
            else
            {
                quest.answer = Useranswer;
                quest.number1 = quiz.num1;
                quest.number2 = quiz.num2;
                quest.oper = quiz.operat;
                quest.count();
                quiz.Expressions.Add(quest);
                return View("Result", quiz);
            }
        }




        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
