using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MvcMovie.Models;

namespace MvcMovie.Controllers
{
    public class DaiLyController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(string MaDaiLy , string TenDaiLy , string DiaChi , string NguoiDaiDien , string DienThoai , string MaHTPP, string TenHTPP)
        {
            string strOutput = "Xin chao" +  MaDaiLy + TenDaiLy + DiaChi + NguoiDaiDien + DienThoai +  MaHTPP + TenHTPP;
            ViewBag.inforDaiLy=strOutput;
            return View();
        } 
    }
}
