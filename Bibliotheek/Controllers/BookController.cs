using System;
using System.Collections.Generic;
using System.Linq;
using Bibliotheek.Models;
using Microsoft.AspNetCore.Mvc;

namespace Bibliotheek.Controllers
{
    public class BookController : Controller
    {
        private readonly Dictionary<int, BookDetailViewModel> _books = new Dictionary<int, BookDetailViewModel>();

        public BookController()
        {
            for (int i = 0; i < 100; i++)
            {
                _books.Add(i,
                    new BookDetailViewModel
                    {
                        Id = i,
                        Author = $"Author {i}",
                        CreationDate = DateTime.Now.AddDays(-1),
                        ISBN = Guid.NewGuid().ToString(),
                        Title = $"Title {i}"
                    });
            }
        }

        [HttpGet("/books")]
        public IActionResult Index()
        {
            var model = new BookListViewModel();
            model.Books = _books.Values.ToList();
            return View(model);
        }

        [HttpGet("/books/{id}")]
        public IActionResult Detail([FromRoute] int id)
        {
            if (!_books.ContainsKey(id))
            {
                return new NotFoundResult();
            }
            var bookDetailViewModel = _books[id];
            return View(bookDetailViewModel);
        }
    }
}