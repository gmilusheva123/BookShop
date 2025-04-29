using Data;
using Data.Models;

namespace Business.Buisness_Logic
{
    public class GenreBusiness
    {
        BookStoreContext bookStoreContext = new BookStoreContext();
        public List<Genre> GetAllOrders()
        {
            return bookStoreContext.Genres.ToList();
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
