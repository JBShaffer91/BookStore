using System;
using BookStore.Models;
namespace BookStore
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Book Store!");

            Console.WriteLine("Enter the book's title:");
            string bookTitle = Console.ReadLine()!;

            Console.WriteLine("Enter the book's author:");
            string bookAuthor = Console.ReadLine()!;

            Console.WriteLine("Enter the book's price:");
            decimal bookPrice = decimal.Parse(Console.ReadLine()!);

            Console.WriteLine("Enter the book's quantity:");
            int bookQuantity = int.Parse(Console.ReadLine()!);

            Book newBook = new Book(bookTitle, bookAuthor, bookPrice, bookQuantity);
            Console.WriteLine($"You've added a new book: {newBook.Title} by {newBook.Author} with a price of {newBook.Price:C2} and a quantity of {newBook.Quantity}");
        }
    }
}
