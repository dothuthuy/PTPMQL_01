using System.Security.Cryptography.X509Certificates;
using Microsoft.AspNetCore.Mvc;
using MvcMovie.Models;

namespace MvcMovie.Controllers
{
    public class PersonController:Controller 
    
    {
public IActionResult Index()
{
    return View();
}

    [HttpPost]
public IActionResult Index(Person ps)
{
    string strOutput ="xinchoa" + ps.PersonId + "-" + ps.FullName + ps.Address;
    ViewBag.infoPerson = strOutput;
    return View();
}
}
    }
