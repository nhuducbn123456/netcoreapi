using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using MvcMovie.Controllers;

namespace MvcMovie.Controllers
{
    public class DemoController :  Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    [HttpPost]
    public IActionResult Index(Person ps)
    {
        string strResult = "Xin chao" + ps.PersonId + "-" + ps.FullName + "-" + ps.Address;
        ViewBag.infoPerson = strResult;
        return View();
    }
    }
}