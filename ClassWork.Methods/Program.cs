using ClassWork.Methods;

int[] numbers = new int[] { 1, 2, 3 };
ReplaceArray(ref numbers);
Console.WriteLine(numbers[0]);

void ReplaceArray(ref int[] arr)
{
    arr = new int[] { 9, 9, 9 };
}

