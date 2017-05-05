using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class ProductRepository
    {
        //Retrieve one product
        public Product Retrieve(int productId)
        {
            //Create the instance of the product class
            //pass in the requested ID
            Product product = new Product(productId);

            //Code that retrieves the defined product
            //Temporary hard coded values to return a populated product
            if(productId == 2)
            {
                product.ProductName = "sunflowers";
                product.ProductDescription = "Assorted sizes";
                product.CurrentPrice = 15.96m;
            }

            return product;
        }

        //Saves the current product
        public bool Save()
        {
            //saves the defined product
            return true;
        }
    }
}
