namespace CoffeeMaker;

public class Account
{
    public double Balance { get; private set; }

    public void Deposit(double amount)
    {
        Balance += amount;
    }
}