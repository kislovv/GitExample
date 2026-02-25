using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using ClassWork.Iterator;


namespace ClassWork;

class Program
{
	static async Task Main(string[] args)
	{
		/*
		Employee employee = new OfficeWorker
		{
			Name = "Kirill",
			InventoryNumber =  Guid.NewGuid().ToString(),
			Company = "OOO Kirill enterprised",
			Exp = 3,
			Salary = 100500
		};

		employee = EmployeeMapper.ChangeWork<Employee, ItSpecialist>(employee, 300_000);
		employee = EmployeeMapper.ChangeWork<Employee, Manager>(employee, 100_000);
		*/
		
		/*
		var productList = new List<Product>
		{
			new Product { Id = Guid.NewGuid(), Name = "Pizza", Price = 10 },
			new Product { Id = Guid.NewGuid(), Name = "Rolls", Price = 20 },
			new Product { Id = Guid.NewGuid(), Name = "Burgers", Price = 30 },
			new Product { Id = Guid.NewGuid(), Name = "Strawberry", Price = 40 },
			new Product { Id = Guid.NewGuid(), Name = "Chips", Price = 50 },
		};

		var storageHandler = new StorageProductHandler(productList);
		var markingHandler = new MarkingProductHandler();
		var finishHandler = new FinishProductHandler();
		storageHandler.Next = markingHandler;
		markingHandler.Next = finishHandler;
		

		var handlerBuilder = new HandlerBuilder<Product>(
			new StorageProductHandler(productList));
		handlerBuilder.AddHandler(new MarkingProductHandler());
		handlerBuilder.AddHandler(new FinishProductHandler());
		
		var startHandler = handlerBuilder.Build();

		var start = new ProductHandlerBuilder(productList)
			.AddMarking()
			.AddFinish()
			.Build();
		
		

	

		var product = new Product
		{
			Name = "Pizza",
		};
		
		storageHandler.Handle(product);
		startHandler.Handle(product);

		Console.WriteLine($"{product.Id}: {product.Name} with price {product.Price}");
		*/

		/*
		var managers = new List<Manager>()
		{
			new Manager()
			{
				Name = "A",
				Department = "Manager1",
				Company = "AAA",
				Exp = 2,
				Salary = 100_000
			},
			new Manager()
			{
				Name = "B",
				Department = "Manager1",
				Company = "AAA",
				Exp = 2,
				Salary = 150_000
			},
			new Manager()
			{
				Name = "C",
				Department = "Manager2",
				Company = "AAA",
				Exp = 3,
				Salary = 400_000
			},
			new Manager()
			{
				Name = "D",
				Department = "Manager2",
				Company = "AAA",
				Exp = 2,
				Salary = 300_000
			},
			new Manager()
			{
				Name = "E",
				Department = "Manager1",
				Company = "AAA",
				Exp = 2,
				Salary = 100_000
			},
		};
		
		managers.Sort(new ManagerComparer());

		Console.WriteLine(string.Join("\n", managers.Select(m => m.Name)));

		var a = new Manager()
		{
			Name = "A",
			Department = "Manager1",
			Company = "AAA",
			Exp = 2,
			Salary = 100_000
		};
		var b = new Manager()
		{
			Name = "A",
			Department = "Manager1",
			Company = "CCC",
			Exp = 5,
			Salary = 100_000
		};

		Console.WriteLine(a.Equals(b));
		Console.WriteLine(a.GetHashCode());
		Console.WriteLine(b.GetHashCode());*/

		Book[] books = new Book[]
		{
			new Book()
			{
				Name = "Граф Монте-Кристо",
				Genre = "Роман",
				PageCount = 1200
			},

			new Book()
			{
				Name = "Песнь льда и пламени",
				Genre = "Фентази",
				PageCount = 6200
			},

			new Book()
			{
				Name = "Три Мушкетера",
				Genre = "Роман",
				PageCount = 1200
			},

			new Book()
			{
				Name = "Lol",
				Genre = "Comics",
				PageCount = 200
			},

			new Book()
			{
				Name = "kek",
				Genre = "Comics",
				PageCount = 9200
			},
			new Book()
			{
				Name = "чебурек",
				Genre = "Comics",
				PageCount = 9200
			},
			
		};

		Library library = new Library(books);

		IEnumerator<Book> librarian = library.GetEnumerator();

		while (librarian.MoveNext())
		{
			Book book = librarian.Current;
			Console.WriteLine($"{book.Name}, {book.Genre}, {book.PageCount}");
		}


		foreach (Book book in library)
		{
			Console.WriteLine($"{book.Name}, {book.Genre}, {book.PageCount}");
		}
		
		

	}
}


