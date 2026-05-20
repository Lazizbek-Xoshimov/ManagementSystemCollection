using BankSystem.Models;

namespace BankSystem;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Welcome to our system!");

        Savingsaccount savingsaccount = new Savingsaccount();

        Console.Write("How much money do you want to deposit in the Bank: ");
        decimal savingsBalance = decimal.Parse(Console.ReadLine());
        savingsaccount.Deposit(savingsBalance);
        savingsaccount.ShowBalance();

        Console.Write("How much money do you want to deposit: ");
        int percent = int.Parse(Console.ReadLine());
        savingsaccount.AddInterest(percent);
        savingsaccount.ShowBalance();

        CreditAccount creditAccount = new CreditAccount();

        Console.Write("How much money do you want to deposit in the Bank: ");
        decimal depositBalance = decimal.Parse(Console.ReadLine());
        creditAccount.Deposit(depositBalance);
        creditAccount.ShowBalance();

        Console.Write("How much money do you want to receive: ");
        decimal amount = decimal.Parse(Console.ReadLine());
        creditAccount.TakeCredit(amount);
        creditAccount.ShowBalance();
    }
}