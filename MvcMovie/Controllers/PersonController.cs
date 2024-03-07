using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Formatters;
using System.Text.Encodings.Web;
namespace MvcMovie.Controllers
{
    public class PersonController : Controller
    { 
    
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index( string PersonId, string FullName, string Address)
        {
            string strOutput = "xin chao" +  PersonId + FullName + "-" + Address;
            ViewBag.Message= strOutput;
            return View();
        }
    }
}
