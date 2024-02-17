using Generics;

var acc1 = new Account
{
    Login = "Petya"
};

var acc2 = new Account
{
    Login = "Vasya"
};


var session = new Session<int>(acc1, acc2);

var tr = new Transaction<string>()
{
    Data = "sddffsdflfksd"
};

session.PushTransaction(new Transaction<int>()
{
    Data = 300,
    Code = 1,
    From = acc1,
    To = acc2
});

session.PushTransaction(new Transaction<int>()
{
    Data = 300,
    Code = 2,
    To = acc2
});

var session2 = new Session<string>(acc1, acc2);

session2.PushTransaction(new Transaction<string>()
{
    Data = "Hi",
    Code = 1,
    From = acc1,
    To = acc2
});

session2.PushTransaction(new Transaction<string>()
{
    Data = "Qq",
    Code = 2,
    From = acc2,
    To = acc1
});

session2.PushTransaction(new Transaction<string>()
{
    Data = "Qq",
    Code = 2,
    From = acc2,
    To = acc1
});


var session3 = new Session<Message>(acc1, acc2);
var session4 = new Session<Article>(acc1, acc2);


session3.PushTransaction(new Transaction<Message>()
{
    Data = new Article
    {
        Title = "Приветствие",
        Data = "Привет!"
    },
    Code = 2,
    From = acc1,
    To = acc2
});

session3.PushTransaction(new Transaction<Message>()
{
    Data = new Message()
    {
        Title = "Приветствие",
        Data = "Привет!"
    },
    Code = 3,
    From = acc1,
    To = acc2
});


var transactionByAcc1 = session.GetMessagesByAccount(acc1);

Console.WriteLine($"Acc1 transactionCount = {transactionByAcc1.Count}");
