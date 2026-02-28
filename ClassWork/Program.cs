using System;


namespace ClassWork;

class Program
{
	
	delegate int MyOperation(int a, int b);
	
	delegate void StudentOp(Student student);
	
	static void Main(string[] args)
	{
		/*
		MyOperation myOperation = Add;
		Console.WriteLine(myOperation(1, 2));
		myOperation = Subtract;
		Console.WriteLine(myOperation(4, 5));
		myOperation = Add;
		myOperation += Subtract;
		Console.WriteLine(myOperation(4, 5));

		myOperation -= Add;
		myOperation += Add;
		Console.WriteLine(myOperation(8, 8));
		*/
		
		/*Student student = new Student();
		StudentOp stOp = AddName;
		stOp+=AddAge;
		stOp+=AddCourse;
		stOp(student);

		Console.WriteLine($"{student.Name}\n {student.Age}\n {student.Course}");*/
		/*
		var account = new Account(NotificationConsole);
		account.Deposit(10);
		account.Withdraw(1000);
		account.Deposit(100);
		account.Withdraw(100);
		account.Deposit(100);
		*/
		WeatherObservable weatherObservable = new WeatherObservable(20.0);
		IObserver pcObserver = new PcWeatherObserver();
		IObserver mobileObserver = new MobileWeatherObserver();
		weatherObservable.UpdateTemperatureDelegate += mobileObserver.Update;
		weatherObservable.UpdateTemperatureDelegate += pcObserver.Update;
		weatherObservable.UpdateTemperature();
	}

	static void NotificationConsole(Account account, AccountArgs args)
	{
		Console.ForegroundColor = args.OperationResult 
			? ConsoleColor.Yellow
			: ConsoleColor.Blue;
		
		Console.WriteLine(args.Message);
		Console.ResetColor();
	}
	
	static int Add(int a, int b)
	{
		return a + b;
	}
	
	static int Subtract(int a, int b)
	{
		return a - b;
	}

	static void AddName(Student student)
	{
		student.Name = Guid.NewGuid().ToString();
	}

	static void AddAge(Student student)
	{
		student.Age = new Random().Next(18,22);
	}

	static void AddCourse(Student student)
	{
		student.Course = Guid.NewGuid().ToString();
	}
}


