using DataAccessLayer.Entities;
using DataAccessLayer.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using VocabularyProject.Models;

namespace VocabularyProject.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        ITestRepository _repository;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
     //       _repository.Add(new Test(){ TestName="Test1"});


            ///Listeler ne tipte oluşturursan o tipte çağırmanı zorunlu kılar, Generic Yapıcaz
            //List<string> stringList = new List<string>();
            //stringList.Add("asaf");

            //List<int> intList = new List<int>();
            //intList.Add(52634);

            return View();
        }

        public IActionResult Privacy()
        {
            var liste = _repository.List();
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
