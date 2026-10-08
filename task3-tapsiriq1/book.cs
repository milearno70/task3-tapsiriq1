using System;
using System.Collections.Generic;
using System.Text;

namespace task3_tapsiriq1
{
    public class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string Isbn { get; set; }

        private bool isAvailable;

        public Book(string title, string author, string isbn)
        {
            this.Title = title;
            this.Author = author;
            this.Isbn = isbn;
            this.isAvailable = true;
        }
        public bool IsAvailable()
        {
            return isAvailable;
        }

        public void Borrow()
        {
            if (isAvailable)
            {
                isAvailable = false;
                Console.WriteLine($"Siz '{Title}' adli ve {Author} muellifinin kitabini goturduz.");
            }
            else
            {
                Console.WriteLine($":((, '{Title}' adli kitab movcud deyil.");
            }
        }
        public void Return()
        {
            if (!isAvailable)
            {
                isAvailable = true;
                Console.WriteLine($"Siz '{Title}' adli ve {Author} muellifinin kitabini qaytardiniz.");
            }
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Kitabin adi: {Title}");
            Console.WriteLine($"Muellif: {Author}");
            Console.WriteLine($"ISBN: {Isbn}");
            Console.WriteLine($"Movcudluq: {(isAvailable ? "Movcuddur" : "Movcud deyil")}");
        }



    }
    }
