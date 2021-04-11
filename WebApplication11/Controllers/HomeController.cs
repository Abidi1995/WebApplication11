//using System.Diagnostics;
//using Microsoft.AspNetCore.Mvc;
//using Microsoft.Extensions.Logging;
//using System.Web.Mvc;
//using WebApplication11.Models;

//namespace Crud.Controllers
//{
//    public class HomeController : Controller
//    {
  
//        private readonly ILogger<HomeController> _logger;

//        public HomeController(HomeController logger)
//        {
            
//        }

//        public System.Web.Mvc.ActionResult Index()
//        {
//            return View();
//        }

//        public System.Web.Mvc.ActionResult Privacy()
//        {
//            return View();
//        }

//        [ResponseCache(Duration = 0, ViewLocationCache = ResponseCacheLocation.None, NoStore = true)]
//        public System.Web.Mvc.ActionResult Error() => View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
//    }
//}
