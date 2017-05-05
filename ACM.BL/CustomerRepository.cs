using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class CustomerRepository
    {
        //Retrieve one customer
        public Customer Retrieve(int customerId)
        {
            Customer customer = new Customer(customerId);
            if(customerId == 1)
            {
                customer.EmailAddress = "CBing@test.me";
                customer.FirstName = "Chandler";
                customer.LastName = "Bing";
            }
            return customer;
        }

        //Retrieve all customers
        public List<Customer> Retrieve()
        {
            return new List<Customer>();
        }

        //Saves the current customer
        public bool Save()
        {
            //saves the defined customer
            return true;
        }
    }
}
