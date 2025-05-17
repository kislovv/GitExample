using System;
using System.Collections.Generic;

namespace ClassWork;

class Program
{
	static void Main(string[] args)
	{
		var alice = new People(){Name = "Alice"};
		var bob = new People(){Name = "Bob"};

		Family<People> family = alice + bob;

		Cat cat = new Cat()
		{
			Name = "Tom",
			Breed = "British",
		};
		
		Exhibitor catExhibitor = (Exhibitor)cat;
	}
}


