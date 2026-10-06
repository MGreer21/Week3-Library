using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryApp
{
    public class Book
    {
        //Private fields

        private string title;
        private string author;
        private int isbn;

        //Public properties

        public string Title
        {
            get { return title; }
            set 
            {  
                // check if incoming char is digit
                if (!value.Any(char.IsDigit))
                {
                    title = value;
                }
                else
                {
                    Console.WriteLine("Cannot enter number for title");
                }

            }
        }

        public string Author
        {
            get { return author; }
            set { author = value; }
        }

        public int ISBN
        {
            get { return isbn; }
            set { isbn = value; }
        }

        //Constructor

        public Book(string bookTitle, string bookAuthor, int bookISBN)
        {
            Title = bookTitle;
            Author = bookAuthor;
            ISBN = bookISBN;
        }

        //Methods

        public void DisplayInfo()
        {
            Console.WriteLine($"Book title: {Title}");
            Console.WriteLine($"Book author: {Author}");
            Console.WriteLine($"Book ISBN: {ISBN}");
        }
    }
}
