using System.Diagnostics.SymbolStore;
using System.Text;

namespace LINQExamples;

public static class ProcedureTasks
{
    public static int[] FindAllDisappearedNums(int[] nums)
    {
        return Enumerable.Range(1, nums.Length)
            .Except(nums)
            .ToArray();
    }

    public static string[] GetFizzBuzz(int[] nums)
    { 
        return nums.Select(item => item % 15 == 0 
            ? "FizzBuzz" : item % 5 == 0 
                ? "Buzz" : item % 3 == 0 
                    ? "Fizz": item.ToString())
            .ToArray();
    }

    public static bool RepeatedSubstringPattern(string text)
    {
        throw new NotImplementedException();
    }
    
    public static bool CheckRecord(string s)
    {
        return !(s.Contains("LLL")
                 || s.Count((symbol) => symbol == 'A') >= 2);
    }

    public static int GetMajorityElement(int[] nums)
    {
        return nums.FirstOrDefault(num => nums.Count(x => x == num) > nums.Length / 2);
    }

    public static bool IsSubsequence(string s, string t)
    {
        var res = Enumerable.Range(0, s.Length)
            .Aggregate((0,0), ((int sIndex, int tIndex) prev, int _) =>
        {
            if (prev.sIndex >= s.Length || prev.tIndex >= t.Length)
                return prev;
            if (s[prev.sIndex] == t[prev.tIndex])
                return (prev.sIndex + 1, prev.tIndex + 1);
            else return (prev.sIndex + 1, prev.tIndex);
        });
        return res.Item2 == t.Length;
    }
    
    private static readonly string[] MorseCodes =
    {
        ".-", "-...", "-.-.", "-..", ".", "..-.", "--.", "....", "..", ".---",
        "-.-", ".-..", "--", "-.", "---", ".--.", "--.-", ".-.", "...", "-",
        "..-", "...-", ".--", "-..-", "-.--", "--.."
    };
    
    public static int UniqueMorseRepresentations(string[] words)
    { 
        return words.Select(word => 
                string.Join("",word.Select(symbol => MorseCodes[symbol - 'a'])))
            .Distinct().Count();
    }

    public static List<string> FindWords(string[] words)
    {
        if (words == null || words.Length == 0)
            throw new NotSupportedException("Input array is empty or null.");
        
        string[] keyboardRows =
        {
            "qwertyuiop", "asdfghjkl", "zxcvbnm"
        };

        return words.Where(word => 
            keyboardRows.Any(row => 
                word.All(row.Contains))).ToList();
        
    }
    
    
    
    public static void PancakeSort(int[] arr)
    {
        for (int currSize = arr.Length; currSize > 1; currSize--)
        {
            int maxIdx = FindMaxIndex(arr, currSize);

            if (maxIdx != currSize - 1)
            {
                Flip(arr, maxIdx);
                Flip(arr, currSize - 1);
            }
        }
    }

    private static void Flip(int[] arr, int i)
    {
        int start = 0;
        while (start < i)
        {
            (arr[start], arr[i]) = (arr[i], arr[start]);
            start++;
            i--;
        }
    }

    private static int FindMaxIndex(int[] arr, int n)
    {
        int maxIdx = 0;
        for (int i = 1; i < n; i++)
            if (arr[i] > arr[maxIdx])
                maxIdx = i;
        return maxIdx;
    }
    
    
    public static void BinaryInsertionSort(int[] arr)
    {
        for (int i = 1; i < arr.Length; i++)
        {
            int key = arr[i];
            int insertedPos = BinarySearch(arr, key, 0, i - 1);

            for (int j = i - 1; j >= insertedPos; j--)
                arr[j + 1] = arr[j];

            arr[insertedPos] = key;
        }
    }

    private static int BinarySearch(int[] arr, int key, int low, int high)
    {
        while (low <= high)
        {
            int mid = (low + high) / 2;
            if (key < arr[mid]) high = mid - 1;
            else low = mid + 1;
        }
        return low;
    }
    
    public static void SlowSort(int[] array, int i, int j)
    {
        if (i >= j) return;

        int m = (i + j) / 2;
        SlowSort(array, i, m);
        SlowSort(array, m + 1, j);

        if (array[j] < array[m])
            (array[j], array[m]) = (array[m], array[j]);

        SlowSort(array, i, j - 1);
    }


    
}