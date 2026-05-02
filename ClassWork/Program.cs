using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Threading;
using System.Threading.Tasks;


namespace ClassWork;

class Program
{
	static void Main(string[] args)
	{
		Order? order = null;

		if (args.Length == 0)
		{
			order = new Order()
			{

			};
		}
		
		order?.CreatedAt = DateTime.Now;

		if (order is not null)
		{
			order.CreatedAt = DateTime.Now;
		}
		
		
		
		/*
		var orderRequest = new OrderRequest()
		{
			Name = "Gamepad",
			Category = "Gaming",
			Id =  Guid.NewGuid(),
		};

		Console.WriteLine(orderRequest.Id);
		
		var order = MiniMapper.Map<OrderRequest, Order>(orderRequest);
		order.Price = 1000;
		order.Count = 100;

		Console.WriteLine(order);
		
		//char[,] garden = new char[10, 10];
		
	
		Thread threadGardenerA = new Thread(() => GardenerA(garden));
		Thread threadGardenerB = new Thread(() => GardenerB(garden));
		threadGardenerA.Start();
		threadGardenerB.Start();
		threadGardenerB.Join();
		threadGardenerA.Join();


		//CountdownEvent cevent = new CountdownEvent(2);
		
		//ThreadPool.QueueUserWorkItem(state => GardenerA(garden, cevent));
		//ThreadPool.QueueUserWorkItem(state => GardenerB(garden, cevent));

		//cevent.Wait();
		
		//Console.ReadLine();
		for (int i = 0; i < 10; i++)
		{
			for (int j = 0; j < 10; j++)
			{
				Console.Write(garden[i, j] + " ");
			}

			Console.WriteLine();
		}
		var list = GenerateRandomVectors(100_000);

		ThreadPool.GetMaxThreads(out var maxWorkerThreads, out var maxCompletionPortThreads);
		for (int i = 0; i < maxWorkerThreads; i++)
		{
			int iCopy = i;
			ThreadPool.QueueUserWorkItem(_ => Range(iCopy, list, 19, maxWorkerThreads));
		}



		Console.ReadLine();
		

		//Console.WriteLine(GetCountOfPrimeNumbers(1000));
		//Console.WriteLine(GetPrimeNumbers(1000).Count);

		Cinema cinema = new  Cinema();
		Type cinemaTypeV1 = cinema.GetType();
		Type cinemaTypeV2 = typeof(Cinema);

		Console.WriteLine(cinemaTypeV1.AssemblyQualifiedName);
		Console.WriteLine(cinemaTypeV2.BaseType);
		Console.WriteLine(cinemaTypeV2.IsGenericType);
		
		
		//cinema.StartSession();
		*/
		
		//TestExecutor.ExecuteAllTests();
		
		/*
		Vector v1 = new Vector()
		{
			X = 1,
			Y = 2,
			Z = 3
		};
		
		Vector v2 = new Vector()
		{
			X = 3,
			Y = 2,
			Z = 1
		};

		v2 += 3;

		Vector v3 = v1 + v2;
		
		Percent p = 150m;
		decimal pValue = (decimal)p;

		object item = new TaskItem("Fix bag", TaskPriority.High, false);
		

		string message = item switch
		{
			TaskItem {IsCompleted: true} => "Task is already completed",
			TaskItem {Priority: TaskPriority.High} taskItem => $"Urgent: {taskItem.Description}",
			TaskItem taskItem =>  $"Regular task: {taskItem.Description}",
			_ => "Uncnown object"
		};
		*/


		string line = "Task42;Higth;Fix login bug";
		string[] data = line.Split(';');
		string id = data[0];
		string priority = data[1];
		string title = data[2];

		ReadOnlySpan<char> lineV2 = line.AsSpan();
		
		int firstSeparator =  lineV2.IndexOf(';');
		ReadOnlySpan<char> idV2 = lineV2[.. firstSeparator];
		
		ReadOnlySpan<char> rest = lineV2[(firstSeparator + 1)..];
		int secondSeparator =  rest.IndexOf(';');
		ReadOnlySpan<char> priorityV2 = rest[..secondSeparator];
		
		ReadOnlySpan<char> titleV2 = rest[(secondSeparator + 1)..];



		int[] nums = [1, 2, 3, 4, 5, 6];
		
		Span<int> nums2 = nums.AsSpan(2, 3);

		for (int i = 0; i < nums2.Length; i++)
		{
			nums2[i] *= 10;
		}

		Span<int> buffer = stackalloc int[10];

		Memory<int> nums3 = nums;

	}

	string Validate(Command command) => command switch
	{
		CreateTask {Title.Length: 0} => "Title is required",
		CreateTask {Priority: < 1 or > 3} => "Priority must be from 1 to 3",
		CompletedTask {TaskId: var id} when id == Guid.Empty => "TaskID is required",
		DeleteTask {Force: false} => "Delete required confirmation",
		_ => "Ok"
	};

	string GetScoreText(int score) => score switch
	{
		< 0 or > 100 => "Invalid score",
		>= 90 => "Excellent",
		>= 71 => "Good",
		>= 56 => "Passed",
		_ => "Failed"
	};
	

	static void GardenerA(char[,] garden, CountdownEvent cevent)
	{
		for (int i = 0; i < garden.GetLength(0); i++)
		{
			for (int j = 0; j < garden.GetLength(1); j++)
			{
				int length = garden.GetLength(0) - 1;
				if (i % 2 == 0)
				{
					if (garden[i, j] != 'b')
					{
						garden[i, j] = 'a';
						Thread.Sleep(1);
					}
				}
				else
				{
					if(garden[i, length - j] != 'b')
					{
						garden[i, length - j] = 'a';
						Thread.Sleep(1);
					}
				}
				
			}
		}

		cevent.Signal();
	}

	static void GardenerB(char[,] garden, CountdownEvent cevent)
	{
		int length = garden.GetLength(0);
		for (int i = length-1; i  >= 0; i--)
		{
			for (int j = length - 1; j > 0; j--)
			{
				
				if (i % 2 == 0)
				{
					if (garden[j, i] != 'a')
					{
						garden[j, i] = 'b';
						Thread.Sleep(1);
					}
				}
				else
				{
					if(garden[length - j, i] != 'a')
					{
						garden[length - j, i] = 'b';
						Thread.Sleep(1);
					}
				}
				
			}
		}
		cevent.Signal();
	}

	static void Range(int n, List<Vector> list, int k, int countsTread)
	{
		for (int i = n; i < list.Count; i += countsTread)
		{
			list[i].X *= k;
			list[i].Y *= k;
			list[i].Z *= k;
			Thread.Sleep(1);
		}

		Console.WriteLine($"Complete {n}");
	}
	public static List<Vector> GenerateRandomVectors(int count, int minValue = -10, int maxValue = 10)
	{
		List<Vector> vectors = new List<Vector>();
		Random random = new Random();
        
		for (int i = 0; i < count; i++)
		{
			int x = minValue + (random.Next() * (maxValue - minValue));
			int y = minValue + (random.Next() * (maxValue - minValue));
			int z = minValue + (random.Next() * (maxValue - minValue));
            
			vectors.Add(new Vector
			{
				X = x,
				Y = y,
				Z = z
			});
		}
        
		return vectors;
	}

	static bool IsPrime(int number)
	{
		for (int i = 2; i < number; i++)
		{
			if (number % i == 0)
			{
				return false;
			}
		}

		return true;
	}

	static int GetCountOfPrimeNumbers(int n)
	{
		int count = 0;
		Parallel.For(1, n, (int i) =>
		{
			if (IsPrime(i))
			{
				Interlocked.Increment(ref count);
			//	count++;
			}
		});
		
		return count;
	}

	static List<int> GetPrimeNumbers(int n)
	{
		List<int> result = new List<int>();
		Lock locker = new();
		
		
		Parallel.For(1, n, (int i) =>
		{
			if (IsPrime(i))
			{
				lock (locker)
				{
					result.Add(i);
				}
			}
		});
		
		return result;
	}
	
	public static int GetMajorityElement(int[] array)
	{
		return array.GroupBy(x => x)
			.ToDictionary(ints =>ints.Key, outs => outs.Count())
			.OrderBy(ints => ints.Value)
			.Last().Key;
	}
	
	
}





