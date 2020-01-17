using System;
using System.Collections.Generic;
using System.Text;

namespace Interface
{
    interface ICustomer
    {
        Object GetCustomer(string customerName);
        double GetBonus();
    }
}