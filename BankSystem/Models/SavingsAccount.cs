namespace BankSystem.Models;

public class Savingsaccount : Account
{
    public void AddInterest(int percent)
    {
        Balance += Balance * percent / 100M;
    }
}