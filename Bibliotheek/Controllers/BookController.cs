using System.Collections.Generic;
using Bibliotheek.Models;
using Microsoft.AspNetCore.Mvc;

namespace Bibliotheek.Controllers
{
    [Route("/books")]
    public class BookController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            var model = new BookListViewModel();
            model.Books = new List<string>();
            model.Books.Add("book 1");
            model.Books.Add("book 2");
            model.Books.Add("book 3");
            model.Books.Add("book 4");
            return View(model);
        }

    }
}