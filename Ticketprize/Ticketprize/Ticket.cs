using System;
using System.Collections.Generic;
using System.Text;

namespace Ticketprize
{
    class Ticket
    {
        // Get ticket price based on user input
        public static double GetTicketPrice(Customer customer)
        {
            if (customer.age < 7)
            {
                return 0;
            }
            else if (customer.mtkMember == "k" && customer.student == "k")
            {
                return 30 * 0.4;
            }
            else if ((customer.age >= 7 && customer.age <= 15) || customer.age >= 65 || customer.conscript == "k")
            {
                return 30 * 0.5;
            }
            else if (customer.student == "k")
            {
                return 30 * 0.55;
            }
            else if (customer.mtkMember == "k")
            {
                return 30 * 0.85;
            }
            else
            {
                return 30;
            }
        }        
    }
}
