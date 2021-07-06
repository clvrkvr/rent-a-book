using System;

/// <summary>
/// Title: Rent A Book
/// Author: Clark Roda
/// </summary>
namespace RentABook
{
    class Book
    {
        /// <summary>
        /// Default Constructor for the Book Class.
        /// </summary>
        public Book()
        {

        }

        /// <summary>
        /// Parameterized Constructor for the Book Class.
        /// It initializes the member fields everytime a new Book Class is instantiated.
        /// It uses the argument being passed to initialize the member fields.
        /// </summary>
        /// <param name="bookTitle">
        /// This method accepts a String type argument.
        /// </param>
        /// <param name="bookAuthor">
        /// This method accepts a String type argument.
        /// </param>
        /// <param name="isbn">
        /// This method accepts an Integer type argument.
        /// </param>
        public Book(string bookTitle, string bookAuthor, int isbn)
        {
            BookTitle = bookTitle;
            BookAuthor = bookAuthor;
            ISBN = isbn;
            Status = true;
        }

        // Properties with their getters and setters.
        public string BookTitle { get; set; }

        public string BookAuthor { get; set; }

        public int ISBN { get; set; }

        public bool Status { get; set; } = false;   // False means it is not available for Checkout.

        /// <summary>
        /// This method allows you to display the information of a book.
        /// </summary>
        public void BookInfo()
        {
            if (Status)
                Console.WriteLine($"{ISBN} - {BookTitle} by {BookAuthor} - AVAILABLE\n");
            else
                Console.WriteLine($"{ISBN} - {BookTitle} by {BookAuthor} - UNAVAILABLE\n");
        }
    }
}
