using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Task_01
{
    public class Ticket
    {
        public Ticket(int n)
        {
            Price = n;
        }

        public int Price { get; private set; }
    }
}