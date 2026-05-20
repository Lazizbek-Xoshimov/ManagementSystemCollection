namespace BankSystem.Models;

public class Account
{
    private decimal _balance;
    protected decimal Balance
    {
        get
        {
            return _balance;
        }
        set
        {
            if (value < 0)
                Console.WriteLine("Balance cannot be a negative value.");
            else
                _balance = value;
        }
    }

    public void Deposit(decimal depositBalance)
    {
        if (depositBalance < 0)
            Console.WriteLine("The balance being deposit cannot be a negative value.");
        else
            _balance += depositBalance;
    }

    public void ShowBalance()
    {
        Console.WriteLine($"Your balance: {_balance}");
    }
}