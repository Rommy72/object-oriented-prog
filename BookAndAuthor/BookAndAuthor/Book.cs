using System;
using System.Collections.Generic;
using System.Text;

namespace BookAndAuthor
{
    class Book
    {
        public string title;
        public string author;
        public string publisher;
        private double price;
        public static string themeClass;

        /// <summary>
        /// Name, Author, Publisher, Price, Class
        /// </summary>
        public Book()
        {
            this.title = string.Empty;
            this.author = string.Empty;
            this.publisher = string.Empty;
            this.price = 0;
        }
        public Book(string title, string author, string publisher, double price, string theme)
        {
            this.title = title;
            this.author = author;
            this.publisher = publisher;
            this.Price = price;
            themeClass = theme;
        }
        public void BookInfoPrinter()
        {
            Console.WriteLine($"Book title: {this.title}\n" +
                $"Author: {this.author}\n" +
                $"Publisher: {this.publisher}\n" +
                $"Theme: {themeClass}\n" +
                $"Price: {this.Price:N2} €.");
        }
        /// Check if string name found in books. If founded prints book info
        public void FindBook(string name)
        {
            if (name == this.title)
            {
                Console.WriteLine($"Book {name} found!");
                Console.WriteLine($"Author: {this.author}\n" +
                    $"Publisher: {this.publisher}\n" +
                    $"Theme: {themeClass}\n" +
                    $"Price: {this.Price:N2} €.");
            }
            else
            {
                Console.WriteLine($"Kirjan nimi ei ollut {name}.");
            }
            Console.WriteLine("");
        }
        ///  sets static Theme to user inputted one.
        public static void ChangeTheme()
        {
            Console.Write("Input new class: ");
            themeClass = Console.ReadLine();
        }
        /// gives 10% sale if books price is over 30€.
        public double Price
        {
            get { return price; }
            set
            {
                if (value > 30)
                {
                 price = value * 0.9;
                }
                else
                {
                   price = value;
                }
            }
        }
        /// <summary>
        /// Read only property of Author
        /// </summary>
        public string Author
        {
            get
            {
                return author;
            }
        }
    }
}


