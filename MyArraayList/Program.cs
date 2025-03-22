namespace MyArraayList;

class Program
{
    static void Main(string[] args)
    {
        MyList<int> myList = new MyList<int>();
        myList.Add(1);
        myList.Add(2);
        myList.Add(3);
        myList.Add(4);
        myList.Add(5);
        var enumerator = myList.GetEnumerator();
        while (enumerator.MoveNext())
        {
            Console.WriteLine(enumerator.Current);
        }
        Console.WriteLine(myList.Count);
        Console.WriteLine(myList[0]);
    }
}