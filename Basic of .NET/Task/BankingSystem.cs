

using System;

public class BankSystem
{
    public static void Main(string[] args)
    {
        Console.WriteLine("----Welcome to the World Bank :) ----");
        bool iterate = true;
        int accountValue = 0;
        string name = "";
        long accNo = -1;
        decimal balance = 0;

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
                    if (accountValue == 0)
                    {
                        accountValue = 1;
                        Console.WriteLine("Please Enter Your Name: ");
                        name = Console.ReadLine();
                        Console.WriteLine("Enter your Account Number: ");
                        accNo = int.Parse(Console.ReadLine());
                        Console.WriteLine("Congratulations! Your Account is Created!!\n");
                    }
                    else
                    {
                        Console.WriteLine("Your Account Already Exists with us!!\n");

                    }
                    break;

                case 2:
                    Console.WriteLine("Depositing money...");
                    // Logic for depositing money
                    Console.Write("Enter amount to deposit: ");
                    string depositAmountInput = Console.ReadLine();
                    if (accountValue == 0)
                    {
                        Console.WriteLine("First Create an Account");
                        break;
                    }
                    if (decimal.TryParse(depositAmountInput, out decimal depositAmount) && depositAmount > 0)
                    {
                        balance += depositAmount; // Add to balance
                        Console.WriteLine($"{name:S}-> Deposited {depositAmount:C}.\t New balance: {balance:C}\n");
                    }
                    else
                    {
                        Console.WriteLine("Invalid deposit amount.");
                    }
                    break;

                case 3:
                    Console.WriteLine("Withdrawing money...");
                    // Logic for withdrawing money
                    Console.Write("Enter amount to withdraw: ");
                    if (accountValue == 0)
                    {
                        Console.WriteLine("First Create an Account");
                        break;
                    }
                    string withdrawAmountInput = Console.ReadLine();
                    if (decimal.TryParse(withdrawAmountInput, out decimal withdrawAmount) && withdrawAmount > 0)
                    {
                        if (balance >= withdrawAmount) // Check if sufficient balance
                        {
                            balance -= withdrawAmount;
                            Console.WriteLine($"{name} Withdrew: {withdrawAmount:C}. Total balance: {balance:C}\n");
                        }
                        else
                        {
                            Console.WriteLine("Insufficient balance.\n");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid withdrawal amount. If you wanna add money select option 2) :) !!\n");
                    }
                    break;

                case 4:
                    Console.WriteLine("\nDisplaying account details...");
                    // Logic for displaying account details
                    if (accountValue == 0)
                    {
                        Console.WriteLine("First Create an Account");
                        break;
                    }
                    Console.WriteLine($"Current Balance: {name:C}\n");
                    Console.WriteLine($"Current Balance: {accNo:C}\n");
                    Console.WriteLine($"Current Balance: {balance:C}\n");
                    break;

                case 5:
                    iterate = false;
                    Console.WriteLine("---Thank You for your time---\n\n");
                    break;
            }




        }

    }
}