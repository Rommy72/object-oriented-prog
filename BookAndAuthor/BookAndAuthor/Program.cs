using System;

namespace BookAndAuthor
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Book firstBook = new Book("Gamify", "Brian Burke", "Bibliomotion", 31.50, "business/strategy");

            Book secondBook = new Book("Tästä eteenpäin", "Marshall Goldsmith", "Talentum", 24.99, "business");

            firstBook.FindBook("Tämä Kirja?");
            firstBook.FindBook("Joku Muu?");
            firstBook.FindBook("Gamify");

            secondBook.FindBook("Toinen Kirja?");
            secondBook.FindBook("Tästä eteenpäin");


            Book.ChangeTheme();


            Console.WriteLine($"{firstBook.title} author is {firstBook.Author}.\n");
            Console.WriteLine($"{secondBook.title} author is {secondBook.Author}.\n");

            Author author = new Author
            {
                Name = "Brian Burke",
                Birthday = "January 214, 1952",
                Book = firstBook
            };
            Console.WriteLine("\nPrint Authors info and his books info:");
            author.PrintInfo();

        }
    }
}
        
    

