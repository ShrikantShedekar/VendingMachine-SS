using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestVendingMachineApp;

namespace VendingMachineTest
{
    [TestClass]
    public class ProductTransactionTest
    {
        VendingMachine vendingMachine;
        public ProductTransactionTest()
        {
            vendingMachine = new VendingMachine();
        }
        [TestMethod]
        public void GetProductCostForCola()
        {
            //Arrange
            decimal ActualValue = 1.00M;
            decimal ExepectedValue = vendingMachine.productDisburstment.GetProductPrice(ProductType.Cola);

            //Act

            //Assert
            Assert.AreEqual(ExepectedValue, ActualValue, "Product value is mismatched for Cola");
        }
        [TestMethod]
        public void GetProductCostForCandy()
        {
            //Arrange
            decimal ActualValue = 0.65M;
            decimal ExepectedValue = vendingMachine.productDisburstment.GetProductPrice(ProductType.Candy);

            //Act

            //Assert
            Assert.AreEqual(ExepectedValue, ActualValue, "Product value is mismatched for Candy");
        }

        [TestMethod]
        public void GetProductCostForChips()
        {
            //Arrange
            decimal ActualValue = 0.50M;
            decimal ExepectedValue = vendingMachine.productDisburstment.GetProductPrice(ProductType.Chips);

            //Act

            //Assert
            Assert.AreEqual(ExepectedValue, ActualValue, "Product value is mismatched for Chips");
        }
    }
}
