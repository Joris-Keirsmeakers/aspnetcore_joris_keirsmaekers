using aspnetcore_keirsmaekers_joris.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace aspnetcore_keirsmaekers_joris.Controllers
{
    [Route("/books")]
    public class BookController : Controller
    {
        Dictionary<int, BookDetailModel> LibraryBooks = new Dictionary<int, BookDetailModel>
            {
                {1, new BookDetailModel{id=1, Title="ASP.net for dummies", Author= "Ceuls R.", ISBN= 111112, CreatedOn = new DateTime(2018, 09, 27) }},
                {2, new BookDetailModel{id=2, Title="Kagelijkse Dost", Author= "Meroen Jeus", ISBN = 111113, CreatedOn = new DateTime(2018, 09, 27)}},
                {3, new BookDetailModel{id=3, Title="Mein Kompfy Chair", Author="Dolfie D", ISBN= 111114, CreatedOn = new DateTime(2018, 09, 27)}},
                {4, new BookDetailModel{id=4, Title="Das Booterhammen", Author="¯\'_(ツ)_/¯" , ISBN= 111115, CreatedOn = new DateTime(2018, 09, 27)}},
                {5, new BookDetailModel{id=5, Title="2012", Author="M. Ayans", ISBN= 111116, CreatedOn = new DateTime(2018, 09, 27)}}
            };

        [HttpGet]
        public IActionResult Index()
        {
            
            var model = new BookListViewModel();
            BookDetailModel book = new BookDetailModel();
            var i = 1;
            model.Books = new List<BookDetailModel>();
            foreach (object librarybook in LibraryBooks)
            {
                book = LibraryBooks[i];
                model.Books.Add(book);
                i++;
            }
            return View(model);
          
        }
        [HttpGet("/{id}")]
        public IActionResult Detail([FromRoute]int id)
        {
            BookDetailModel book = new BookDetailModel();
            book = LibraryBooks[id];
            return View(book);
        }
    }
}