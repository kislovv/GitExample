using System;


namespace ClassWork;

class Program
{
	static void Main(string[] args)
	{
		var myLinkedList = new MyLinkedList<int>();
		myLinkedList.Add(1);
		myLinkedList.Add(2);
		myLinkedList.Add(3);
		myLinkedList.Add(4);
		myLinkedList.Add(5);
		myLinkedList.Remove(4);
		myLinkedList.Remove(2);
		myLinkedList.Add(8);

		foreach (var item in myLinkedList)
		{
			Console.WriteLine(item);
		}
	}
}


