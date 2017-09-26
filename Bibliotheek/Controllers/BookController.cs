using System;
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
            model.Books = new List<BookDetailViewModel>();
            model.Books.Add(new BookDetailViewModel(){Author = "author 1", CreationDate = DateTime.Now, ISBN = "isbn 1", Title = "title 1"});
            model.Books.Add(new BookDetailViewModel(){Author = "author 2", CreationDate = DateTime.Now, ISBN = "isbn 2", Title = "title 2"});
            model.Books.Add(new BookDetailViewModel(){Author = "author 3", CreationDate = DateTime.Now, ISBN = "isbn 3", Title = "title 3"});
            model.Books.Add(new BookDetailViewModel(){Author = "author 4", CreationDate = DateTime.Now, ISBN = "isbn 4", Title = "title 4"});
            return View(model);
        }

    }
}