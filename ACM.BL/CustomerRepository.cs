using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class CustomerRepository
    {
        private AddressRepository addressRepository { get; set; }

        public CustomerRepository()
        {
            addressRepository = new AddressRepository();
        }

        //Retrieve one customer
        public Customer Retrieve(int customerId)
        {
            Customer customer = new Customer(customerId);
            customer.AddressList = addressRepository.RetrieveByCustomerId(customerId).ToList();

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
        public bool Save(Customer customer)
        {
            var success = true;

            if (customer.HasChanges && customer.IsValid)
            {
                if (customer.IsValid)
                {
                    //Call an Insert Stored Procedure
                }
                else
                {
                    //Call an Update Stored Procedure
                }
            }

            return success;
        }
    }
}
