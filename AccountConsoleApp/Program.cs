using BankAccount;

namespace AccountConsoleApp;

class Program
{
    static void ShowNotification(Account account, AccountArgs args)
    {
        Console.WriteLine(args.Message);
        Console.WriteLine($"Остаток на счету: {account.Balance}");
    }

    static void SaveNotification(string message)
    {
        File.AppendAllText("notification.txt", $"{message}\n\r");
    }
    
    static void Main(string[] args)
    {
        var bankAccount = new Account();
        bankAccount.Notify += (account, args) =>
        {
            Console.WriteLine(args.Message);
            Console.WriteLine($"Остаток на счету: {account.Balance}");
        };
        
        bankAccount.Deposit(100);
        bankAccount.Withdraw(100);
        bankAccount.Withdraw(100);
    }
}