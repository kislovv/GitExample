using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

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

		var produt = new Product
		{
			Name = "Pizza",
		};
		
		storageHandler.Handle(produt);

		Console.WriteLine($"{produt.Id}: {produt.Name} with price {produt.Price}");

	}
}


