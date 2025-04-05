namespace BankAccount;

public delegate void Notify(Account account, AccountArgs accountArgs);

public class Account
{
    public event Notify Notify = (_, _) => {};
    public decimal Balance { get; private set; } = 0;
    public void Deposit(decimal amount)
    {
        Balance += amount;
        Notify(this, new AccountArgs
            {
                Balance = amount,
                Message = $"Deposit {amount}"
            });
    }

    public void Withdraw(decimal amount)
    {
        if (Balance - amount < 0)
        {
            Notify(this, new AccountArgs
            {
                Balance = amount,
                Message = "Insufficient balance"
            });
            return;
        }
        Balance -= amount;
        
        Notify(this, new AccountArgs
        {
            Balance = amount,
            Message = $"Withdraw {amount}"
        });
    }
    
}