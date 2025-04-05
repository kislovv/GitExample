namespace LinkedList11407;

class Program
{
    static void Main(string[] args)
    {
        var linkedList = new MyLinkedList<string>("a");
        linkedList.Add("b");
        linkedList.Add("c");
        linkedList.AppendFirst("d");
        linkedList.Remove("d");

        foreach (var item in linkedList)
        {
            Console.WriteLine(item);
        }
    }
}