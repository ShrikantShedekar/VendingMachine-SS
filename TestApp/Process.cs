using System;
using System.Collections.Generic;

namespace TestVendingMachineApp
{
    public class Process
    {
        static VendingMachine vendingMachine = new VendingMachine();

        public static void CaptureInput(out int clearNumber)
        {
            if (vendingMachine.coinsAccepted.GetBalanceAmount() <= 0)
            {
                Console.WriteLine(vendingMachine.DisplayMessageForCoins());
                Console.WriteLine("1 - INSERT COIN");
                clearNumber = 1;
            }
            else
            {
                Console.WriteLine("1 - INSERT COIN \t2 - DISPENSE PRODUCT \t3 - EXIT");
                Console.Write("Your Option ? ");
                string numberInput = Console.ReadLine();
                clearNumber = Process.ValidateInput(numberInput);
            }
        }

        public static void AcceptCoin(out int clearNumber, out OptionType MenuType)
        {

            Console.WriteLine("1 - Quarter \t 2 - Dime \t 3 - Nickel \t 4 - Penny");


            Console.Write("Your Option ? ");
            string numberInput = Console.ReadLine();
            clearNumber = ValidateInput(numberInput);

            Coin coinType = vendingMachine.coinsAccepted.GetCoinType(clearNumber);
            if (coinType == Coin.Other)
            {
                Console.WriteLine("INVALID COIN");
            }
            else
            {
                vendingMachine.AcceptCoins(coinType);
                Console.WriteLine(vendingMachine.DisplayMessageForCoins());
            }
            MenuType = OptionType.MainOption;
            clearNumber = 1;
        }

        public static void DispenseProduct(out int clearNumber,out OptionType MenuType)
        {
            Console.WriteLine("Select Product : \t 1 - Cola $1.00 \t 2 - Chips $0.50 \t 3 - Candy $0.65");
            Console.Write("Your Option ? ");
            string numberInput = Console.ReadLine();
            clearNumber = ValidateInput(numberInput);
            string msg = string.Empty;
            switch (clearNumber)
            {
                case 1:
                    msg = vendingMachine.DispenseProduct(ProductType.Cola);
                    break;
                case 2:
                    msg = vendingMachine.DispenseProduct(ProductType.Chips);
                    break;
                case 3:
                    msg = vendingMachine.DispenseProduct(ProductType.Candy);
                    break;
                default:
                    break;
            }
            MenuType = OptionType.MainOption;
            clearNumber = 1;
            Console.WriteLine(msg);
            if (vendingMachine.coinsAccepted.GetBalanceAmount() > 0)
            {
                Console.WriteLine(vendingMachine.DisplayMessageForCoins());
            }
        }

        public static int ValidateInput(string inputString)
        {
            int clearNumber = 0;
            while (!int.TryParse(inputString, out clearNumber))
            {
                Console.WriteLine("Enter Valid Input");
                inputString = Console.ReadLine();
            }
            return clearNumber;
        }
    }
}