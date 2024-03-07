using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;
namespace MvcMovie.Controllers
{
    public class EmployeeController : Controller
    { 
        // GET: /Employee/Index
        public string Index()
        {
            return "Nhan vien Do Thu Thuy 2021050893";
        }
        
        // GET: /Employee/Welcome/ 

        public string Welcome()
        {
            return "Xin chao ...";
        }
    }
}
