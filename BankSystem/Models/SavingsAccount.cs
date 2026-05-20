namespace BankSystem.Models;

public class Savingsaccount : Account
{
    public decimal AddInterest(int percent)
    {
        Balance += Balance * percent / 100M;

        return Balance;
    }
}