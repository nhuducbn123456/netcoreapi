using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;
namespace MvcMovie.Controllers
{
    public class Person : Controller
    {
        public string? PersonId { get; internal set; }
        public string? FullName { get; internal set; }
        public string? Address { get; internal set; }

        // GET: /HelloWorld/
        public IActionResult th1()
        {
            return View();
        } 
        // GET: /HelloWorld/Welcome/ 

        public string Welcome()
        {
            return "This is the Welcome action method...";
        }
    }
}
