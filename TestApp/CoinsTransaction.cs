using System;
using System.Collections.Generic;
using System.Text;

namespace TestVendingMachineApp
{
    public class CoinsTransaction
    {
        private List<Coin> Coins { get; set; }
        private decimal TotalDeposited { get; set; }
        public CoinsTransaction()
        {
            Coins = new List<Coin>();
        }

        //Getting balance of the Coins deposited
        public decimal GetBalanceAmount()
        {
            return TotalDeposited;
        }

        //Adding coins
        internal void DepositAmount(Coin coin)
        {
            TotalDeposited += GetCoinValue(coin);
        }

        

        //Dispensing Amount once the product is dispensed
        internal void DeductAmount(decimal amount)
        {
            TotalDeposited -= amount;
        }

        public decimal GetCoinValue(Coin coin)
        {
            decimal value = 0;
            switch (coin)
            {
                case Coin.Penny:
                    value = 0.01M;
                    break;
                case Coin.Nickel:
                    value = 0.05M;
                    break;
                case Coin.Dime:
                    value = 0.1M;
                    break;
                case Coin.Quarter:
                    value = 0.25M;
                    break;
                default:
                    break;
            }
            return value;
        }
        public Coin GetCoinType(int option)
        {
            switch (option)
            {
                case 1:
                    return Coin.Quarter;
                case 2:
                    return Coin.Dime;
                case 3:
                    return Coin.Nickel;
                case 4:
                    return Coin.Penny;
                default:
                    return Coin.Other;
            }
        }

    }
}
