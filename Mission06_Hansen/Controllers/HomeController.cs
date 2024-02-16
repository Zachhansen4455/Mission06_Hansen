using Microsoft.AspNetCore.Mvc;
using Mission06_Hansen.Models;
using System.Diagnostics;

namespace Mission06_Hansen.Controllers
{
    public class HomeController : Controller
    {

        private FormContext _context;
        
        public HomeController(FormContext temp) //constructor for the DB
        {
            _context = temp;
        }


        public IActionResult Index() // view index page
        {
            return View();
        }

        public IActionResult GetToKnow() // view Get to know you page
        {
            return View();
        }

        [HttpGet]
        public IActionResult Form() // view the form
        {
            return View();
        }

        [HttpPost]
        public IActionResult Form(Form response) 
        {
            _context.Forms.Add(response); // Add record to the database
            _context.SaveChanges();

            return View("Confirmation", response);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
