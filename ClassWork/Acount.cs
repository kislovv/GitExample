using System;

namespace ClassWork;

public delegate void Notification(Account account, AccountArgs args);
public class Account
{
    public event Notification Notify;
    public double Balance { get; private set; }

    public Account(Notification notification)
    {
        Notify = notification;
    }

    public void Deposit(double amount)
    {
        Balance += amount;
        Notify?.Invoke(this, new AccountArgs
            {
                Message = $"Your balance is {Balance}",
                OperationResult = true
            });
    }

    public void Withdraw(double amount)
    {
        if (Balance - amount < 0)
        {
            Notify?.Invoke(this, new AccountArgs
            {
                Message = $"Not enough money :( ",
                OperationResult = false
            });
            return;
        }    
        Balance -= amount;
        Notify?.Invoke(this, new AccountArgs
            {
                Message = $"Your balance is {Balance}",
                OperationResult = true
            });
    }
}