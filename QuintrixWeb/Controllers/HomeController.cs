using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using QuintrixWeb.Models;
using System.Diagnostics;
using QuintrixWeb.Data;


namespace QuintrixWeb.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IUserRolesServices _userRolesServices;
       
        public HomeController(ILogger<HomeController> logger, IUserRolesServices _userRoleServices)
        {
            _logger = logger;
            _userRolesServices = _userRoleServices;
        }
       
        
        public IActionResult Index()
        {
            return View();
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
        /// <summary>
        /// Run it to create admin 
        /// </summary>
        /// <returns></returns>
        public async Task<IActionResult> EnsureRoleAndUsers()
        {
           // await _userRolesServices.EnsureAdminUserRole();
            return RedirectToAction("Index");

        }

       
    }
}