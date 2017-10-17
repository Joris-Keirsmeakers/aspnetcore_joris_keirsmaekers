using System.Collections.Generic;
using Bibliotheek.Entities;

namespace Bibliotheek.Services
{
    public interface IBookService
    {
        List<Book> GetAllBooks();
        Book GetBookById(int id);
        List<Genre> GetAllGenres();
        Genre GetGenreById(int id);
        void Persist(Book book);
        void Delete(int id);
    }
}