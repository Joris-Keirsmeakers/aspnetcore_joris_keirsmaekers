using System.Collections.Generic;
using Bibliotheek.Controllers;
using Bibliotheek.Entities;
using Bibliotheek.Services;
using Moq;
using Xunit;

namespace Bibliotheek.UnitTests
{
    public class BookControllerTests
    {
        private readonly BookController _controller;
        private readonly Mock<IBookService> _bookService = new Mock<IBookService>(MockBehavior.Strict);

        public BookControllerTests()
        {
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
        }
}