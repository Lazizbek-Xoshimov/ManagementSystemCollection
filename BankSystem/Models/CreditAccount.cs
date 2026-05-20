namespace BankSystem.Models;

public class CreditAccount : Account
{
    public void TakeCredit(decimal amount)
    {
        if (Balance < amount)
            Console.WriteLine("Not enough balance.");
        else
            Balance -= amount;
    }
}