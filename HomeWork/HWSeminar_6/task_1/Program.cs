
Console.WriteLine("Enter numbers separated by spaces: ");
int[] array_in = Console.ReadLine().Split().Select(int.Parse).ToArray();
Console.WriteLine($"Number of positive numbers: {CheckAmountPositiveNumber(array_in)} ");
int CheckAmountPositiveNumber(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] > 0)
        {
            count++;
        }
    }
    return count;
}

