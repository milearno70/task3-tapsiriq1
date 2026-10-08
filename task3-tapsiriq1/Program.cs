using System;
using System.Collections.Generic;
using System.Text;

namespace task3_tapsiriq1
{ 
    public class Program
    {
        static void Main(string[] args)
        {
            library mylibrary = new library();

            mylibrary.AddBook(new Book("The Great Gatsby", "F. Scott Fitzgerald", "1001"));
            mylibrary.AddBook(new Book("To Kill a Mockingbird", "Harper Lee", "1002"));
            mylibrary.AddBook(new Book("1984", "George Orwell", "1003"));
            mylibrary.AddBook(new Book("Pride and Prejudice", "Jane Austen", "1004"));
            mylibrary.AddBook(new Book("The Catcher in the Rye", "J.D. Salinger", "1005"));
            mylibrary.AddBook(new Book("The Hobbit", "J.R.R. Tolkien", "1006"));
            mylibrary.AddBook(new Book("Moby-Dick", "Herman Melville", "1007"));
            mylibrary.AddBook(new Book("War and Peace", "Leo Tolstoy", "1008"));
            mylibrary.AddBook(new Book("The Odyssey", "Homer", "1009"));
            mylibrary.AddBook(new Book("The Divine Comedy", "Dante Alighieri", "1010"));
            mylibrary.AddBook(new Book("The Brothers Karamazov", "Fyodor Dostoevsky", "1011"));
                
            Console.WriteLine("kitab siyahisi:");
            mylibrary.DisplayAllBooks();

            Console.WriteLine("\nKitab borc almaq:");
            mylibrary.BorrowBookByIndex(2);
            mylibrary.BorrowBookByIndex(5);
            

            Console.WriteLine("\nEn son kitab siyahisi:");
            mylibrary.DisplayAllBooks();
        }
    }
}