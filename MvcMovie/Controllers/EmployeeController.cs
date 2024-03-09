using Microsoft.AspNetCore.Mvc;
using MvcMovie.Models;
using System.Reflection.Metadata.Ecma335;
using System.Text.Encodings.Web;
namespace MvcMovie.Controllers
{
    public class EmployeeController : Controller
    { 

        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
    public IActionResult Index ( Empolyee ps)
    { 
        string strOutput = "xin chao" + ps.PersonId + ps.FullName + ps.Address + ps.EmployeeId + ps.Age;
        ViewBag.info=strOutput;
        return View();
    }
        }
    }
}
