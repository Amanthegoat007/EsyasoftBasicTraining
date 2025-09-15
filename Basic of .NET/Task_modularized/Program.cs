using System;

public class BankSystem
{
    public static void Main(string[] args)
    {
        Console.WriteLine("----Welcome to the World Bank :) ----");
        bool iterate = true;
        BankAccount account = new BankAccount();

        while (iterate)
        {
            Console.WriteLine("\n\n 1). Create a new Bank Account\n 2). Deposit Money\n 3). Withdraw Money\n 4) Display Account Details\n 5) Exit\n");
            int input = int.Parse(Console.ReadLine());
            if (input < 1 || input > 5)
            {
                Console.WriteLine("Enter Valid Operations From the menu!!!");
                continue;
            }

            switch (input)
            {
                case 1:
                    account.CreateAccount();
                    break;

                case 2:
                    account.DepositMoney();
                    break;

                case 3:
                    account.WithdrawMoney();
                    break;

                case 4:
                    account.DisplayAccountDetails();
                    break;

                case 5:
                    iterate = false;
                    Console.WriteLine("---Thank You for your time---\n\n");
                    break;
            }
        }
    }
}