using System;
using System.Collections.Generic;
using System.Text;

namespace TestVendingMachineApp
{
    public class VendingMachine
    {
        public CoinsTransaction coinsAccepted = new CoinsTransaction();
        public CoinsTransaction coinsReturned = new CoinsTransaction();
        public ProductTransaction productDisburstment = new ProductTransaction();

        public string ProductDisplayMessage = string.Empty;
        public string CoinsDisplayMessage = string.Empty;

        //Accepting Coins 
        public void AcceptCoins(Coin coin)
        {
            if (coin == Coin.Penny)
            {
                coinsReturned.DepositAmount(coin);
            }
            else
            {
                coinsAccepted.DepositAmount(coin);
            }
        }
        public string DisplayMessageForCoins()
        {
            decimal amount = coinsAccepted.GetBalanceAmount();

            CoinsDisplayMessage = "Current Balance " + string.Format("{0:C}", amount);

            return CoinsDisplayMessage;
        }

        //Dispensing the product
        public string DispenseProduct(ProductType productType)
        {
            decimal productAmount = productDisburstment.GetProductPrice(productType);
            if (coinsAccepted.GetBalanceAmount() >= productAmount)
            {
                coinsAccepted.DeductAmount(productAmount);
                ProductDisplayMessage = "THANK YOU";
            }
            else
            {
                ProductDisplayMessage = "PRICE " + string.Format("{0:C}", productAmount);
            }
            return ProductDisplayMessage;
        }

        
    }
}
