using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace BookStoreTest
{
    public class BookStoreBasicFunctionsTest
    {
        [Fact]
        public void GetBookByIdTest()
        {
            var result = BookStoreBasicFunctions.GetBookById(2);
            Assert.True(result.BookTitle == "Canterbury Tales");
            Assert.True(result.YearOfRelease == 1403);
        }

        [Fact]
        public void GetAllBooks()
        {
            var result = BookStoreBasicFunctions.GetAllBooks();
            Assert.True(result.Count == 4);
        }

        [Fact]
        public void GetBookByTitle()
        {
            var result = BookStoreBasicFunctions.GetBookByTitle("The Travels of Marco Polo ");
            Assert.True(result.BookTitle == "The Travels of Marco Polo ");
            Assert.True(result.YearOfRelease == 1305);
        }

        [Fact]
        public void GetBooksByAuthor()
        {
            var result = BookStoreBasicFunctions.GetBooksByAuthor("The Coast");
            Assert.True(result.Count == 1);
 
        }
    }
}
