using DRPC.SERVICE.Service;
using DRPC.WebApp.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace DRPC.WebApp.Controllers
{
    public class HomeController : Controller
    {
       private readonly IUsuarioService _usuarioService;

        public HomeController(IUsuarioService usuarioServ)
        {
            _usuarioService = usuarioServ;
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
    }
}