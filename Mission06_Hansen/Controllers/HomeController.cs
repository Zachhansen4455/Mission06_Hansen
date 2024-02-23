using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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
            //get categories into the form
            ViewBag.Categories = _context.Categories.ToList();

            return View();
        }

        [HttpPost]
        public IActionResult Form(Movie response) 
        {
            _context.Movies.Add(response); // Add record to the database
            _context.SaveChanges();

            return View("Confirmation", response);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        [HttpGet]
        public IActionResult ViewData() // load up data set
        {
            //linq
            var movies = _context.Movies
                .Include(x => x.Category).ToList();

            return View(movies);
        }

        [HttpGet]
        public IActionResult Edit(int id) // get the info for the edits and go back to form to edit them
        {
            var recordToEdit = _context.Movies
                .Single(x => x.MovieId == id);

            ViewBag.Categories = _context.Categories.ToList();

            return View("Form", recordToEdit);
        }
        
        [HttpPost]
        public IActionResult Edit(Movie updatedInfo) //save the updated form. return to table
        {
            _context.Update(updatedInfo);
            _context.SaveChanges();

            return RedirectToAction("ViewData");
        }

        [HttpGet]
        public IActionResult Delete(int id) // get the record that you want to delete
        {
            var recordToDelete = _context.Movies
                .Single(x => x.MovieId == id);

            return View(recordToDelete);
        }

        [HttpPost]
        public IActionResult Delete(Movie movie) // save the delete and return to table
        {
            _context.Movies.Remove(movie);
            _context.SaveChanges();

            return RedirectToAction("ViewData");
        }
    }
}
