using System;
using System.Collections.Generic;
using Bibliotheek.Controllers;
using Bibliotheek.Data;
using Bibliotheek.Entities;
using Bibliotheek.Models;
using Bibliotheek.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Moq;
using Xunit;

namespace Bibliotheek.UnitTests
{
    public class BookControllerTests
    {
        private readonly BookController _controller;
        private readonly Mock<IBookService> _bookService;

        public BookControllerTests()
        {
            _bookService =
                new Mock<IBookService>(MockBehavior.Strict);
            _controller = new BookController(_bookService.Object);
        }

        [Fact]
        public void WeCanConvertABookToAViewModel()
        {
            var goingIn = new Book()
            {
                Genre = new Genre {Name = "Genre"},
                ISBN = "abc",
                Title = "titel",
                Authors = new List<AuthorBook>
                {
                    new AuthorBook {Author = new Author {FirstName = "ABC", LastName = "CDE"}}
                }
            };
            var comingOut = _controller.ConvertBookToEditDetailViewModel(goingIn);
            Assert.Equal("Genre", comingOut.Genre);
            //TODO: check the other properties
        }

        [Fact]
        public void WeCanConvertABookToAViewModelWithMultipleAuthors()
        {
            //TODO what the method name says.
        }

        //TODO create a test for ConvertBookToBookDetailViewModel

        [Fact]
        public void WeCanUseAMoqForDbAccess()
        {
            _bookService.Setup(x => x.GetBookById(12)).Returns(new Book {Id = 12}).Verifiable();
            _bookService.Setup(x => x.GetAllGenres()).Returns(new List<Genre>()).Verifiable();
            //what's the difference between line 57 & 58?
            var actionResult = (ViewResult) _controller.Detail(12);
            var model = actionResult.Model as BookEditDetailViewModel;
            Assert.NotNull(model);
            Assert.Equal(12, model.Id);
            _bookService.Verify();
        }
    }
}