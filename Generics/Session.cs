namespace Generics;

public class Session<T>
{
    private readonly List<Transaction<T>> _transactions = new();
    private readonly HashSet<int> _transactionCodes = new();
    private readonly Account _first;
    private readonly Account _second;
    
    public Session(Account first, Account second)
    {
        _first = first;
        _second = second;
    }

    public bool PushTransaction(Transaction<T> transaction)
    {
        if (transaction.From == null || transaction.To == null)
        {
            return false;
        }
        if (((transaction.From.Login.Equals(_first.Login) &&
              transaction.To.Login.Equals(_second.Login)) ||
             (transaction.To.Login.Equals(_first.Login) &&
              transaction.From.Login.Equals(_second.Login))) 
            && _transactionCodes.Add(transaction.Code))
        {
            if (transaction.From.Login.Equals(_first.Login))
            {
                _first.MessageCount++;
            }
            else
            {
                _second.MessageCount++;
            }
            
            _transactions.Add(transaction);
            Console.WriteLine($"{transaction.Code}: Message from {transaction.From.Login}: {transaction.Data?.ToString()}");
            return true;
        }

        return false;
    }

    public List<Transaction<T>> GetMessagesByAccount(Account account)
    {
        if (!account.Login.Equals(_first.Login) &&
            !account.Login.Equals(_second.Login))
        {
            return new List<Transaction<T>>();
        }
        var result = new List<Transaction<T>>();
        
        foreach (var transaction in _transactions)
        {
            if (transaction.From!.Login.Equals(account.Login))
            {
                result.Add(transaction);
            }
        }

        return result;
    }
}