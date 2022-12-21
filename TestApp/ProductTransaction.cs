using System;
using System.Collections.Generic;
using System.Text;

namespace TestVendingMachineApp
{
    public class ProductTransaction
    {
        private List<Product> Products { get; set; }
        public ProductTransaction()
        {
            Products = new List<Product>();
            Products.Add(new Product() { ProductType = ProductType.Candy, Price=0.65M});
            Products.Add(new Product() { ProductType = ProductType.Chips, Price=0.50M });
            Products.Add(new Product() { ProductType = ProductType.Cola, Price = 1.00M });
        }

        public decimal GetProductPrice(ProductType productType)
        {
            int index = Products.FindIndex(x => x.ProductType == productType);
            if (index > -1)
            {
                return Products[index].Price;
            }
            return 0;
        }
    }
}
