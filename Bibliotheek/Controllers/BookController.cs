using System;
using System.Collections.Generic;
using System.Linq;
using Bibliotheek.Data;
using Bibliotheek.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Bibliotheek.Controllers
{
    public class BookController : Controller
    {
        private readonly EntityContext _entityContext;

        public BookController(EntityContext entityContext)
        {
            _entityContext = entityContext;
        }

        [HttpGet("/books")]
        public IActionResult Index()
        {
            var model = new BookListViewModel();
            model.Books = new List<BookDetailViewModel>();
            var allBooks = _entityContext.Books.Include(x => x.Authors).ThenInclude(x => x.Author).ToList();
            foreach (var book in allBooks)
            {
                var vm = new BookDetailViewModel();
                vm.Title = book.Title;
                vm.Author = "";
                foreach (var ba in book.Authors)
                {
                    vm.Author = ba.Author.FirstName + " " + ba.Author.LastName;
                }
                model.Books.Add(vm);
            }
            return View(model);
        }

        [HttpGet("/books/{id}")]
        public IActionResult Detail([FromRoute] int id)
        {
            var vm = new BookDetailViewModel();
            return View(vm);
        }
    }
}