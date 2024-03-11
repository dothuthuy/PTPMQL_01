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
        public IActionResult Index(string MaDaiLy , string TenDaiLy , string DiaChi , string NguoiDaiDien , string DienThoai , string MaHTPP, string TenHTPP)
        {
            string strOutput = "Xin chao" +  MaDaiLy + TenDaiLy + DiaChi + NguoiDaiDien + DienThoai +  MaHTPP + TenHTPP;
            ViewBag.inforDaiLy=strOutput;
            return View();
        }
        }
    }
