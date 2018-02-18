using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Webshop
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                //creating items for interaction
                List<OrderItem> orderItemList = new List<OrderItem>();
                for (int i = 0; i < 5; i++)
                {
                    orderItemList.Add(new OrderItem(i.ToString()));
                    //OrderItem orderItem = new OrderItem(i.ToString());
                }
                Console.WriteLine();

                //creating customer
                Customer customer = new Customer();
                customer.Name = "Customer 1";

                //items available to customer
                customer.AvailableItems(orderItemList);

                //create order
                customer.CreateOrder();
            } 
        }
    }
}
