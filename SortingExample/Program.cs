namespace SortingExample;

class Program
{
    static void Main(string[] args)
    {
        int[] array = [1, 9, 18, 2, 4, 7, 11, 9, 16, 22];
        ShakerSort(array);
        Console.WriteLine(string.Join(" ", array));
    }


    static void BubbleSort(int[] array)
    {
        for (int i = 0; i < array.Length - 1; i++)
        {
            bool swapped = false;
            for (int j = 0; j < array.Length - 1 - i; j++)
            {
                if (array[j] > array[j + 1])
                {
                    (array[j], array[j + 1]) = (array[j + 1], array[j]);
                    swapped = true;
                }
            }
            if (!swapped)
            {
                break;
            }
        }
    }

    static void ShakerSort(int[] array)
    {
        (int l,int  r) indexes = (0, array.Length - 1);
        
        while (indexes.l <= indexes.r)
        {
            bool swapped = false;
            for (int i = indexes.l; i < indexes.r - 1; i++)
            {
                if (array[i] > array[i + 1])
                {
                    (array[i], array[i + 1]) = (array[i + 1], array[i]);
                    swapped = true;
                }
            }
            indexes.r--;
            
            for (int j = indexes.r; j > indexes.l + 1; j--)
            {
                if (array[j] < array[j - 1])
                {
                    (array[j], array[j - 1]) = (array[j - 1], array[j]);
                    swapped = true;
                }
            }
            indexes.l++;

            if (!swapped)
            {
                break;
            }
        }
    }
}