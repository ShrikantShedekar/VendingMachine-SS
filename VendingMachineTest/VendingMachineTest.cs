using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TestVendingMachineApp;

namespace VendingMachineTest
{
    [TestClass]
    public class VendingMachineTest
    {
        VendingMachine vendingMachine;
        public VendingMachineTest()
        {
            vendingMachine = new VendingMachine();
        }

        
        


        [TestMethod]
        public void DisplayMessageForCoins_When_No_Coins_Accepted()
        {
            //Arrange
            string ExpectedValue = "Current Balance $0.00";

            //Act
            string ActualValue= vendingMachine.DisplayMessageForCoins();

            //Assert
            Assert.AreEqual(ExpectedValue, ActualValue, "Message is not proper");
        }

        [TestMethod]
        public void DisplayMessageForCoins_When_Coins_Accepted()
        {
            //Arrange
            string ExpectedValue = "Current Balance $0.25";

            //Act
            vendingMachine.AcceptCoins(Coin.Quarter);
            string ActualValue = vendingMachine.DisplayMessageForCoins();

            //Assert
            Assert.AreEqual(ExpectedValue, ActualValue, "Message is not proper");
        }

        [TestMethod]
        public void DispenseProduct_When_Dispense_Product_And_Balance_Is_Less_Than_ProductAmount_Then_Show_Product_Price()
        {
            //Arrange
            string ExpectedValue = "PRICE $0.65";

            //Act
            vendingMachine.AcceptCoins(Coin.Quarter);
            string ActualValue = vendingMachine.DispenseProduct(ProductType.Candy);

            //Assert
            Assert.AreEqual(ExpectedValue, ActualValue, "Message is not proper");
        }
        [TestMethod]
        public void DispenseProduct_When_Dispense_Product_And_Balance_Is_More_Than_ProductAmount_Then_Show_THANK_YOU()
        {
            //Arrange

            string ExpectedValue = "THANK YOU";

            //Act
            vendingMachine.AcceptCoins(Coin.Quarter);
            vendingMachine.AcceptCoins(Coin.Quarter);
            string ActualValue = vendingMachine.DispenseProduct(ProductType.Chips);

            //Assert
            Assert.AreEqual(ExpectedValue, ActualValue, "Message is not proper");
        }
    }
}
