using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;
namespace MvcMovie.Controllers
{
    public class PersonController : Controller
    { 
        // GET: /Person/
        public string Index()
        {
            return "Do Thu Thuy 2021050893";
        }
        
        // GET: /Person/Welcome/ 

        public string Welcome()
        {
            return "Xin chao ...";
        }
    }
}
