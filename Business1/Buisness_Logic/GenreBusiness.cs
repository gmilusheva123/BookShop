using Data;
using Data.Models;
using System.Collections.Generic;
using System.Linq;

namespace Business.Buisness_Logic
{
    public class GenreBusiness
    {
        BookStoreContext bookStoreContext = new BookStoreContext();
        public GenreBusiness(BookStoreContext context)
        {
            bookStoreContext = context;
        }
        public List<Genre> GetAllGenres()
        {
            return bookStoreContext.Genres.ToList();
        }
        public Genre GetGenreByName(string name)
        {
            return bookStoreContext.Genres.FirstOrDefault(g => g.Name == name);
        }
        public Genre GetGenreByID(int id)
        {
            return bookStoreContext.Genres.Find(id);
        }
        public string AddGenre(Genre genre)
        {
            bookStoreContext.Genres.Add(genre);
            bookStoreContext.SaveChanges();
            return "You added a genre.";
        }
        public string RemoveGenre(int id)
        {
            bookStoreContext.Genres.Remove(GetGenreByID(id));
            bookStoreContext.SaveChanges();
            return "Genre is removed successfully.";
        }
        public string UpdateGenre(Genre genre)
        {
            Genre genre1 = GetGenreByID(genre.GenreID);
            bookStoreContext.Entry(genre1).CurrentValues.SetValues(genre);
            bookStoreContext.SaveChanges();
            return $"Genre has been updated successfully.";
        }
    }
}
