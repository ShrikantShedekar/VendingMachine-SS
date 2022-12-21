using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestVendingMachineApp;

namespace VendingMachineTest
{
    [TestClass]
    public class CoinsTransactionTest
    {
        VendingMachine vendingMachine;
        public CoinsTransactionTest()
        {
            vendingMachine = new VendingMachine();
        }

        [TestMethod]
        public void AddCoin_When_Insert_Coin_Quarter_Then_Value_Increases()
        {
            //Arrange
            decimal ActualValue = 0.25M;

            //Act
            vendingMachine.AcceptCoins(Coin.Quarter);
            decimal ExpectedValue = vendingMachine.coinsAccepted.GetBalanceAmount();
            //Assert
            Assert.AreEqual(ExpectedValue, ActualValue, "Value is not increasing");
        }

        [TestMethod]
        public void AddCoin_When_Insert_Coin_Dime_Then_Value_Increases()
        {
            //Arrange
            decimal ActualValue = 0.10M;

            //Act
            vendingMachine.AcceptCoins(Coin.Dime);
            decimal ExpectedValue = vendingMachine.coinsAccepted.GetBalanceAmount();
            //Assert
            Assert.AreEqual(ExpectedValue, ActualValue, "Value is not increasing");
        }

        [TestMethod]
        public void AddCoin_When_Insert_Coin_Nickel_Then_Value_Increases()
        {
            //Arrange
            decimal ActualValue = 0.05M;

            //Act
            vendingMachine.AcceptCoins(Coin.Nickel);
            decimal ExpectedValue = vendingMachine.coinsAccepted.GetBalanceAmount();
            //Assert
            Assert.AreEqual(ExpectedValue, ActualValue, "Value is not increasing");
        }

        [TestMethod]
        public void AddCoin_When_Insert_Coin_Penny_Then_Value_Is_Not_Increases()
        {
            //Arrange
            decimal ActualValue = 0.01M;

            //Act
            vendingMachine.AcceptCoins(Coin.Penny);
            decimal ExpectedValue = vendingMachine.coinsAccepted.GetBalanceAmount();

            //Assert
            Assert.AreNotEqual(ExpectedValue, ActualValue, "Value is increasing");
        }

        [TestMethod]
        public void AddCoin_When_Insert_All_Coins_Then_Value_Increases()
        {
            //Arrange
            decimal ActualValue = 0.40M;

            //Act
            vendingMachine.AcceptCoins(Coin.Quarter);
            vendingMachine.AcceptCoins(Coin.Nickel);
            vendingMachine.AcceptCoins(Coin.Dime);
            vendingMachine.AcceptCoins(Coin.Penny);
            decimal ExpectedValue = vendingMachine.coinsAccepted.GetBalanceAmount();

            //Assert
            Assert.AreEqual(ExpectedValue, ActualValue, "Value is not matching");
        }

        [TestMethod]
        [DataRow(1, Coin.Quarter)]
        [DataRow(2, Coin.Dime)]
        [DataRow(3, Coin.Nickel)]
        [DataRow(4, Coin.Penny)]
        
        public void GetCoinType_When_Pass_Option_Then_Verify_CoinsType(int option,Coin coin )
        {
            Assert.AreEqual(vendingMachine.coinsAccepted.GetCoinType(option), coin, "Invalid coin");
        }

    }
}
