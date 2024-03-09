// See https://aka.ms/new-console-template for more information

class Program
{
    static void Main()
    {
        int[] array = new[] { 4, 7, 8, 5, 2 };
        var sortedList = InsertSort(array);
        foreach (var item in sortedList)
        {
            Console.WriteLine(item);
        }
    }

    static LinkedList<int> InsertSort(int[] array)
    {
        LinkedList<int> list = new LinkedList<int>(array);
        
        if (array.Length < 2)
        {
            return list;
        }
        LinkedListNode<int> current = list.First!;


        do
        {
            if (current.Next!.Value >= current.Value)
            {
                current = current.Next;
                continue;
            }

            LinkedListNode<int> insertNode = current.Next;
            LinkedListNode<int> pivot = current;

            while (pivot != null && pivot.Value > insertNode.Value)
            {
                pivot = pivot.Previous!;
            }
            list.Remove(insertNode);
            if (pivot == null)
            {
                list.AddFirst(insertNode);
            }
            else
            {
                list.AddAfter(pivot, insertNode);
            }

        } while (current != list.Last );

        return list;
    }
    
}