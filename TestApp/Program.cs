using System;
using System.Collections.Generic;

namespace TestVendingMachineApp
{
    class Program 
    {
        static VendingMachine vendingMachine = new VendingMachine();
        static OptionType MenuType = OptionType.MainOption;       


        static void Main(string[] args)
        {
            int clearNumber = 1;

            string numberInput = string.Empty;
            do
            {

                Process.CaptureInput(out clearNumber);
                switch (clearNumber)
                {
                    case 1:             // Accept Coin
                        clearNumber = 0;
                        Process.AcceptCoin(out clearNumber, out MenuType);
                        break;
                    case 2:             // Dispense Product
                        clearNumber = 0;
                        MenuType = OptionType.ProductOption;
                        Process.DispenseProduct(out clearNumber, out MenuType);
                        break;
                    case 3:             //Exit
                        break;
                    default:
                        Console.WriteLine("Invalid Input");
                        break;
                }

            } while (clearNumber != 3 && MenuType == OptionType.MainOption);
        }

    }
    
}
