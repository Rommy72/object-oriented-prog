using System;
using System.Collections.Generic;
using System.Text;

namespace kirjaohjelma
{
    class Book
    {
        public string Title;
        public string Author;
        public int Id;
        public double Price;

        public Book()
        {
            Title = "Turmoil";
            Author = "Agatha.G Fuller";
            Id = 1;
            Price = 9.90;
        }

        public Book(string title, string author, int id, double price)
        {
            Title = title;
            Author = author;
            Id = id;
            Price = price;
        }

        public void printBook()
        {
            Console.WriteLine($"Title: {Title}\nAuthor: {Author}\nId: {Id}\nPrice: {Price:c}");
        }

        public string CompareBook(Book book)
        {
            if (this.Price > book.Price)
            {
                return $"{this.Title} on kalliimpi {book.Title}.";
            }
            else if (this.Price < book.Price)
            {
                return $"{this.Title} on Halvempi {book.Title}.";
            }
            else
            {
                return "Kirjat on saman hintaisia";
            }
        }
    }
}
