using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MvcMovie.Models;


namespace MvcMovie.Controllers
{
    public class HeThongPhanPhoi : Controller
    {

        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(string MaHTPP , string TenHTPP)
        {
            string strOutput = "Xin chao" + "," + MaHTPP +  TenHTPP;
            ViewBag.infoHeThongPhanPhoi=strOutput;
            return View();

        }

    }
    
}