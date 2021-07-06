using System;
using System.Collections.Generic;

/// <summary>
/// Title: Rent A Book
/// Author: Clark Roda
/// </summary>
namespace RentABook
{
    class Library
    {
        // Member Field
        private List<Book> catalogue;

        /// <summary>
        /// Default Constructor for the Library Class.
        /// It initializes the member field everytime a new Library Class is instantiated.
        /// </summary>
        public Library()
        {
            catalogue = new List<Book>();
        }

        /// <summary>
        /// This method allows you to add a book in the system.
        /// It requires the Book's Title, Book Author's Name and Book's ISBN.
        /// When there requirements are met, the book is then added to the system and will be available for rent.
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
        public void AddABook(string bookTitle, string bookAuthor, int isbn)
        {
            Book book = new Book(bookTitle, bookAuthor, isbn);
            Console.WriteLine($"{book.ISBN} - {book.BookTitle} by {book.BookAuthor} has been added to the system!\n");
            catalogue.Add(book);
        }

        /// <summary>
        /// This method allows you to remove a book from the system.
        /// It uses the argument being passed to traverse through the system and check if the book is in the system or not.
        /// If the book is in the system, it will remove that book.
        /// It does not allow you to remove a book that does not exist in the system.
        /// </summary>
        /// <param name="isbn">
        /// This method accepts an Integer type argument.
        /// </param>
        public void RemoveABook(int isbn)
        {
            Book book = new Book();
            book = catalogue.Find(x => x.ISBN == isbn);
            if (catalogue.Remove(book))
                Console.WriteLine($"{book.ISBN} - {book.BookTitle} by {book.BookAuthor} has been removed from the system!\n");
            else
                Console.WriteLine($"Sorry! The book with the ISBN: {isbn}, is not in the system!\n");
        }

        /// <summary>
        /// This method allows you to find a book based on the Book's Title.
        /// It uses the argument being passed to traverse through the system and check if the book is in the system or not.
        /// If the book is in the system, it will display the information of that book.
        /// </summary>
        /// <param name="bookTitle">
        /// This method accepts a String type argument.
        /// </param>
        public void FindABookByBookTitle(string bookTitle)
        {
            Book book = new Book();
            book = catalogue.Find(x => x.BookTitle.Contains(bookTitle));
            if (catalogue.Contains(book))
                book.BookInfo();
        }

        /// <summary>
        /// This method allows you to find a book based on the Book Author's Name.
        /// It uses the argument being passed to traverse through the system and check if the book is in the system or not.
        /// If the book is in the system, it will display the information of that book.
        /// </summary>
        /// <param name="bookAuthor">
        /// This method accepts a String type argument.
        /// </param>
        public void FindABookByBookAuthor(string bookAuthor)
        {
            Book book = new Book();
            book = catalogue.Find(x => x.BookAuthor.Contains(bookAuthor));
            if (catalogue.Contains(book))
                book.BookInfo();
        }

        /// <summary>
        /// This method allows you to find a book based on the Book Title or Book Author's Name.
        /// It uses the argument being passed to traverse through the system and check if the book is in the system or not.
        /// If the book is in the system, it will display the information of that book.
        /// </summary>
        /// <param name="bookInfo">
        /// This method accepts a String type argument.
        /// </param>
        public void FindABookByBookTitleOrBookAuthor(string bookInfo)
        {
            Book book = new Book();
            book = catalogue.Find(x => ((x.BookTitle.Contains(bookInfo)) || (x.BookAuthor.Contains(bookInfo))));
            if (catalogue.Contains(book))
                book.BookInfo();
            else
                Console.WriteLine("The book you're looking for is not in the system!\n");
        }

        /// <summary>
        /// This method allows you to rent a book from the system.
        /// It uses the argument being passed to traverse through the system and check if the book is in the system or not.
        /// If the book is in the system, it checks if it's available for renting or not.
        /// When the book is rented, it changes the status of the book to unavailable where other renters can't renting the book.
        /// </summary>
        /// <param name="isbn">
        /// This method accepts an Integer type argument.
        /// </param>
        public void CheckoutABook(int isbn)
        {
            Book book = new Book();
            book = catalogue.Find(x => x.ISBN == isbn);
            if (catalogue.Contains(book))
            {
                if (book.Status)
                {
                    book.BookInfo();
                    book.Status = false;
                }
                else
                    book.BookInfo();
            }
            else if (!catalogue.Contains(book))
                Console.WriteLine($"Sorry! There is no book in the system that has an ISBN: {isbn}\n");
        }

        /// <summary>
        /// This method allows you to return a book to the system.
        /// It uses the argument being passed to traverse through the system and check if the book was returned or not.
        /// If the book has been returned, it will not allow the renter to return the book.
        /// When the book is returned, it changes the status of the book to available where other renters can start renting the book.
        /// </summary>
        /// <param name="isbn">
        /// This method accepts an Integer type argument.
        /// </param>
        public void ReturnABook(int isbn)
        {
            Book book = new Book();
            book = catalogue.Find(x => x.ISBN == isbn);
            if (catalogue.Contains(book))
            {
                if (book.Status)
                    Console.WriteLine($"Cannot return {book.BookTitle}, as it has not been rented!\n");
                else
                {
                    Console.WriteLine($"{book.BookTitle} has been returned successfully!\n");
                    book.Status = true;
                }
            }
        }

        /// <summary>
        /// This method allows you to display the list of books in the system.
        /// </summary>
        public void LibraryInformation()
        {
            foreach (Book book in catalogue)
            {
                book.BookInfo();
            }
        }
    }
}
