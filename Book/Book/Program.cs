using System;
using System.Globalization;

namespace kirjaohjelma
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            CultureInfo.CurrentCulture = new CultureInfo("fi-FI");
            Book book = new Book();

            book.printBook();

            Book newBook = new Book("Cenocide", "M.C Wensforth", 2, 19.90);

            newBook.printBook();

            Console.WriteLine(newBook.CompareBook(book));

            Console.ReadKey();
        }
    }
}