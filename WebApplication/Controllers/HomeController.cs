using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using WebApplication.Models;

namespace WebApplication.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private IList<IndexModel> _listOfdata;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
            _listOfdata = new List<IndexModel>();
            _listOfdata.Add(new IndexModel { Id = 1, Name = "Ab", Email = "ab@gmail.com"});
            _listOfdata.Add(new IndexModel { Id = 2, Name = "CD", Email = "cd@gmail.com"});
            _listOfdata.Add(new IndexModel { Id = 3, Name = "EF", Email = "ef@gmail.com"});
            _listOfdata.Add(new IndexModel { Id = 4, Name = "GH", Email = "gh@gmail.com"});
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(IndexModel model)
        {
            model.Id = _listOfdata.Count() + 1 ;
            _listOfdata.Add(model);
            return RedirectToAction(nameof(ShowData));
        }

        public IActionResult ShowData()
        {
            return View(_listOfdata);
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
