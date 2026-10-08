using System;
using System.Collections.Generic;
using System.Text;

namespace task3_tapsiriq1
{
    public class library
    {
        private List<Book> books;
        public library()
        {
            books = new List<Book>();
        }
        public void AddBook(Book book)
        {
            books.Add(book);
            Console.WriteLine($"Kitab '{book.Title}' ve {book.Author} muellifinin kitabini kutubxanaya elave etdiniz.");
        }
        public void BorrowBookByIndex(int index)
        {
            if (index >= 0 && index < books.Count)
            {
                books[index].Borrow();
            }
            else
            {
                Console.WriteLine("Duzgun indeks daxil edin.");
            }
        }

        public void ReturnBookByIndex(int index)
        {
            if (index >= 0 && index < books.Count)
            {
                books[index].Return();
            }
            else
            {
                Console.WriteLine("Duzgun indeks daxil edin.");
            }
        }

        public void DisplayAllBooks()
        {
            Console.WriteLine("Kutubxanadaki butun kitablari gosterir:");
            for (int i = 0; i < books.Count; i++)
            {
                Console.WriteLine($"Indeks: {i}");
                books[i].DisplayInfo();
                Console.WriteLine();
            }
        }
    }
}
