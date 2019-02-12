using System;
using System.Collections.Generic;
using System.Text;

namespace Ticketprize
{
    class Customer
    {
        public int age;
        public string conscript;
        public string mtkMember;
        public string student;
        public double price;

        public Customer()
        {
            // Ask for customer information
            Console.Write("ikä: ");
            age = int.Parse(Console.ReadLine());

            do
            {
                // Keep screen format "nice"
                Console.Clear();
                Console.Write($"ikä:{age}\n ");
                Console.Write("MTK:n jäsen?k/e: ");
                mtkMember = Console.ReadLine().ToLower();
            }
            while (mtkMember != "k" && mtkMember != "e");

            do
            {
                // Keep  screen format "nice"
                Console.Clear();
                Console.Write($"ikä{age}\n MTK:jäsen?{mtkMember}\n");
                Console.Write("opiskelija?k/e: ");
                student = Console.ReadLine().ToLower();
            }
            while (student != "k" && student != "e");

            do
            {
                // Keep  screen format "nice"
                Console.Clear();
                Console.Write($"ikä{age}\n MTK:jäsen?{mtkMember}\n opiskelija{student}\n");
                Console.Write("varumies?k/e: ");
                conscript = Console.ReadLine().ToLower();
            }
            while (conscript != "k" && conscript != "e");
        }



        public void PrintCustomer(Customer customer)
        {
            // Print user info with modified price
            Console.Clear();
            Console.WriteLine($"ikä:\t{customer.age}\nLipunhinta:\t{Ticket.GetTicketPrice(customer):C}");
        }
    }
}    




        

    

            


            
        
    
