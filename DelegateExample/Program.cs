using DelegateExample;
using DelegateExample.TemperatureAgent;

/*
var account = new Account(100, Notification);

void Notification(string message)
{
    Console.WriteLine(message);
}


account.Add(50);
account.Notify += (string message) => 
    File.WriteAllText("notification.txt", message);

account.Blocked(70);
*/

var hydrometcenter = new HydroMetCenter();

var firstClient = new ConsoleTemperatureClient();
var secondClient = new ConsoleTemperatureClient();
var thirdClient = new ConsoleTemperatureClient();

hydrometcenter.Update += firstClient.Update;
hydrometcenter.Update += secondClient.Update;
hydrometcenter.Update += thirdClient.Update;

hydrometcenter.UpdateTemp();
hydrometcenter.Update -= firstClient.Update;
Thread.Sleep(2000);
hydrometcenter.UpdateTemp();
hydrometcenter.Update -= secondClient.Update;
Thread.Sleep(2000);
hydrometcenter.UpdateTemp();
hydrometcenter.Update -= thirdClient.Update;
