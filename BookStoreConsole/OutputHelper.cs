using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using BookStore.Models;
using CsvHelper;
using System.IO;
using System.Globalization;
using BookStore;

namespace BookStoreConsole
{
    class OutputHelper
    {
        public void WriteToConsole(List<Book> books)
        {
            Console.WriteLine("List of Books");
            foreach(var b in books)
            {
                Console.WriteLine($"BookID: {b.BookId}  Title: {b.BookTitle}    Release Year: {b.YearOfRelease}");
            }
        }

        public void WriteToCSV(List<Book> books) 
        {
            using (var writer = new StreamWriter("C:\\Users\\soque\\Desktop\\NEIT Schoolwork\\SE407.70_Advanced.NET\\BookStore\\Books.csv"))
            using (var csv = new CsvWriter(writer, CultureInfo.InvariantCulture))
            {
                csv.WriteRecords(books);
            }
        }

        class Program
        {
            static void Main(string[] args)
            {
                var b = BookStoreBasicFunctions.GetAllBooks();
                var oh = new OutputHelper();
                oh.WriteToConsole(b);
                oh.WriteToCSV(b);
            }
        }
    }

}
