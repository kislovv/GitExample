// See https://aka.ms/new-console-template for more information

using ParallelTasks;

var eratosfenTask = new EratosfenTask(100);

eratosfenTask.CountPrimeNumbers();

Console.WriteLine(eratosfenTask.PrimeNumbersCount);
