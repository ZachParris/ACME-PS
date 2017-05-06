using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    class AddressRepository
    {
        //Retrieve one address.
        public Address Retrieve(int addressId)
        {
            //Create the instance of the address class
            //pass in the requested ID
            Address address = new Address(addressId);
            //Code that retrieves the defined address
            if (addressId == 10)
            {
                address.StreetLine1 = "Main St";
                address.StreetLine2 = "Franklin Rd";
                address.City = "Nashville";
                address.State = "TN";
                address.Country = "USA";
                address.PostalCode = "77069";
            }

            return address;
        }

        public IEnumerable<Address> RetrieveByCustomerId(int customerId)
        {
            var addressList = new List<Address>();
            Address address = new Address(1)
            {
                AddressType = 1,
                StreetLine1 = "Main St",
                StreetLine2 = "Franklin Rd",
                City = "Nashville",
                State = "TN",
                Country = "USA",
                PostalCode = "77069"
            };
            addressList.Add(address);

            address = new Address(2)
            {
                AddressType = 2,
                StreetLine1 = "Bag End",
                StreetLine2 = "Bagshot Row",
                City = "Hobbiton",
                State = "Shire",
                Country = "Middle Earth",
                PostalCode = "145"
            };
            addressList.Add(address);
            return addressList;
        }

        //Saves the current address
        public bool Save(Address address)
        {
            //saves the defined address
            return true;
        }
    }
}
