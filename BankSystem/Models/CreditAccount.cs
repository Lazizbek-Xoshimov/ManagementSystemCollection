namespace BankSystem.Models;

public class CreditAccount : Account
{
    public void TakeCredit(decimal amount)
    {
        if (amount < Balance)
            Console.WriteLine("Not enough balance.");
        else
            Balance -= amount;
    }
}