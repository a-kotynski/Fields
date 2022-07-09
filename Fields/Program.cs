using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fields
{
    // Field initialization
    public class Customer
    {
        List<Order> Orders;
        public Customer()
        {
            Orders = new List<Order>(); // initialization of the field using a default
                                        // constructor (parameterless)
        }
    }
    // different way of field initialization
    public class Customer1
    {
        List<Order> Orders = new List<Order>();
    }

    // read-only fields
    public class Customer2
    {
        readonly List<Order> Orders = new List<Order>();
    }
    class Program
    {
        static void Main(string[] args)
        {

        }
    }
}