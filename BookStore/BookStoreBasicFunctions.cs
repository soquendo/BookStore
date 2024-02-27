using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookStore.Models;

namespace BookStore
{
    public class BookStoreBasicFunctions
    {
        public static Book GetBookById(int BookId)
        {
            using (var db = new SE407_BookStoreContext())
            {
                return db.Books.Find(BookId);
            }
        }

        public static List<Book> GetAllBooks()
        {
            using (var db = new SE407_BookStoreContext())
            {
                return db.Books.ToList();
            }
        }

        public static Book GetBookByTitle(String BookTitle)
        {
            using (var db = new SE407_BookStoreContext())
            {
                return db.Books.Where(b => b.BookTitle == BookTitle).FirstOrDefault();
            }
        }

        public static List<Book> GetBooksByAuthor(String AuthorLast)
        {
            using (var db = new SE407_BookStoreContext())
            {
                return db.Books.Where(b => b.Author.AuthorLast == AuthorLast).ToList();
            }
        }

    }
}
