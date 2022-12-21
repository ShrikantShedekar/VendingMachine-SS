using System;
using System.Collections.Generic;
using System.Text;

namespace TestVendingMachineApp
{
    public class Product
    {
        public ProductType ProductType { get; set; }
        public decimal Price { get; set;  }
    }
    public enum ProductType 
    {
        Cola,
        Candy,
        Chips
    }
}
