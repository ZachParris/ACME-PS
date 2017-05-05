using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class OrderRepository
    {
        //Retrieve one order
        public Order Retrieve(int orderId)
        {
            Order order = new Order(orderId);
            //retrieves the defined order
            if(orderId == 10)
            {
                order.OrderDate = new DateTimeOffset(2014, TimeSpan.Zero);
            }

            return order;
        }

        //Saves the current order
        public bool Save()
        {
            //saves the defined order
            return true;
        }

    }
}
