namespace DelegateExample;
public class Account(int money, Account.Notification notification)
{
    public delegate void Notification(string message);
    public event Notification Notify = notification;
    public int Money { get; private set; } = money;

    public void Add(int money)
    {
        Money += money;
        Notify?.Invoke($"Added {money}");
    }
    
    public void Blocked(int money)
    {
        Money -= money;
        Notify?.Invoke($"Blocked {money}");
    }
}