using System;

public class BankAccount
{
    public int AccountValue  = 0;
    public string Name  = "";
    public long AccNo  = -1;
    public decimal Balance  = 0;

    public void CreateAccount()
    {
        if (AccountValue == 0)
        {
            AccountValue = 1;
            Console.WriteLine("Please Enter Your Name: ");
            Name = Console.ReadLine();
            Console.WriteLine("Enter your Account Number: ");
            AccNo = int.Parse(Console.ReadLine());
            Console.WriteLine("Congratulations! Your Account is Created!!\n");
        }
        else
        {
            Console.WriteLine("Your Account Already Exists with us!!\n");
        }
    }

    public void DepositMoney()
    {
        if (AccountValue == 0)
        {
            Console.WriteLine("First Create an Account");
            return;
        }
        
        Console.WriteLine("Depositing money...");
        Console.Write("Enter amount to deposit: ");
        string depositAmountInput = Console.ReadLine();
        
        if (decimal.TryParse(depositAmountInput, out decimal depositAmount) && depositAmount > 0)
        {
            Balance += depositAmount;
            Console.WriteLine($"{Name}-> Deposited {depositAmount:C}.\t New balance: {Balance:C}\n");
        }
        else
        {
            Console.WriteLine("Invalid deposit amount.");
        }
    }

    public void WithdrawMoney()
    {
        if (AccountValue == 0)
        {
            Console.WriteLine("First Create an Account");
            return;
        }
        
        Console.WriteLine("Withdrawing money...");
        Console.Write("Enter amount to withdraw: ");
        
        string withdrawAmountInput = Console.ReadLine();
        if (decimal.TryParse(withdrawAmountInput, out decimal withdrawAmount) && withdrawAmount > 0)
        {
            if (Balance >= withdrawAmount)
            {
                Balance -= withdrawAmount;
                Console.WriteLine($"{Name} Withdrew: {withdrawAmount:C}. Total balance: {Balance:C}\n");
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
    }

    public void DisplayAccountDetails()
    {
        if (AccountValue == 0)
        {
            Console.WriteLine("First Create an Account");
            return;
        }
        
        Console.WriteLine("\nDisplaying account details...");
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine($"Account Number: {AccNo}");
        Console.WriteLine($"Current Balance: {Balance:C}\n");
    }
}