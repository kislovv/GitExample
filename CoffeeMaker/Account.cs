namespace CoffeeMaker;

public class Account
{
    public double Balance { get; private set; }

    public bool Withdraw(double amount)
    {
        if (amount > Balance)
        {
            return false;
        }
        Balance -= amount;
        return true;
    }

    public void Deposit(double amount)
    {
        Balance += amount;
    }
}