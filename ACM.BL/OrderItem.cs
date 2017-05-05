using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class OrderItem
    {
        public OrderItem()
        {

        }

        public OrderItem(int orderItemId)
        {
            this.OrderItemId = orderItemId;
        }

        public int OrderItemId { get; private set; }
        public int OrderQuantity { get; set; }
        public int ProductId { get; set; }
        public decimal? PurchasePrice { get; set; }

        //Retrieve one order item
        public OrderItem Retrieve(int orderItemId)
        {
            //retrieves the defined order item
            return new OrderItem();
        }

        //Saves the current order item
        public bool Save()
        {
            //saves the defined order item
            return true;
        }

        public bool Validate()
        {
            var isValid = true;

            if (OrderQuantity <= 0) isValid = false;
            if (ProductId <= 0) isValid = false;
            if (PurchasePrice == 0) isValid = false;

            return isValid;
        }
    }
}
