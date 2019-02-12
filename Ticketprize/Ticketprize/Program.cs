using System;

namespace Ticketprize
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding =System.Text.Encoding.UTF8;
            // Create new customer, run program once

            var customer = new Customer();

            customer.PrintCustomer(customer);



        }
    }
}
