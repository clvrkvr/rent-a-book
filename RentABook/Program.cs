using System;

/// <summary>
/// Title: Rent A Book
/// Author: Clark Roda
/// </summary>
namespace RentABook
{
    class Program
    {
        static void Main(string[] args)
        {
            // Creating a new Library and adding books to it.
            Library newLibrary = new Library();
            newLibrary.AddABook("The Fellowship of the Ring", "J. R. R. Tolkien", 252);
            newLibrary.AddABook("A Game of Thrones", "George R. R. Martin", 486);
            newLibrary.AddABook("Harry Potter and the Philosopher's Stone", "J. K. Rowling", 934);
            newLibrary.AddABook("The Way of Kings", "Brandon Sanderson", 353);
            newLibrary.AddABook("Fahrenheit 451", "Ray Bradbury", 974);
            newLibrary.AddABook("Pride and Prejudice", "Jane Austen", 530);
            newLibrary.AddABook("The Jane Austen Book Club", "Karen Joy Fowler", 261);
            newLibrary.AddABook("The Hitchhiker's Guide to the Galaxy", "Douglas Adams", 913);
            newLibrary.AddABook("Fablehaven", "Brandon Mull", 810);
            newLibrary.AddABook("The Name of the Wind", "Patrick Rothfuss", 407);

            // The program will keep running until the user inputs "Exit".
            string input = Console.ReadLine();
            while (!input.Equals("Exit"))
            {
                string[] inputArr = input.Split(' ');
                string data = "";
                for (int i = 1; i < inputArr.Length; i++)
                    data += inputArr[i] + " ";

                if (inputArr[0] == "find")
                    newLibrary.FindABookByBookTitleOrBookAuthor(data.Remove(data.Length - 1, 1));
                else if (inputArr[0] == "checkout")
                    newLibrary.CheckoutABook(Int32.Parse(inputArr[1]));
                else if (inputArr[0] == "return")
                    newLibrary.ReturnABook(Int32.Parse(inputArr[1]));
                else if (inputArr[0] == "printallbooks")
                    newLibrary.LibraryInformation();
                else if (inputArr[0] == "addabook")
                {
                    Console.Write("Book Title: ");
                    string bookTitle = Console.ReadLine();
                    Console.Write("Book Author: ");
                    string bookAuthor = Console.ReadLine();
                    Console.Write("ISBN: ");
                    int isbn = Int32.Parse(Console.ReadLine());
                    newLibrary.AddABook(bookTitle, bookAuthor, isbn);
                }
                else if (inputArr[0] == "removeabook")
                {
                    Console.Write("ISBN: ");
                    int isbn = Int32.Parse(Console.ReadLine());
                    newLibrary.RemoveABook(isbn);
                }
                else
                    Console.WriteLine("Invalid Input!\n");

                input = Console.ReadLine();
            }
            Console.ReadKey();
        }
    }
}
