using System.Reflection.Metadata.Ecma335;
using Microsoft.AspNetCore.Mvc;

namespace MvcMovie.Controllers
{
    public class DaiLy : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }

}