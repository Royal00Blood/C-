int[] numbers = new int[123];

Random random = new Random();

void FillArray(int[] array)
{
    Random random = new Random();
    for(int i = 0; i< array.Length; i++)
    {
        array[i] = random.Next(0,1000);
    }
}
void PrintArray(int[] array)
{
    Console.WriteLine();
    for(int i = 0; i< array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
int CountNumberRange(int[] array, int min_range, int max_range)
{
    int count = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i]<=max_range & array[i]>=min_range)
        {
            count+=1;
        }
    }
    return count;
}

FillArray(numbers);
PrintArray(numbers);
bool is_parsed = int.TryParse(Console.ReadLine(),out int min_range);
bool is_parsed_2 = int.TryParse(Console.ReadLine(),out int max_range);
Console.WriteLine($"Number count = {CountNumberRange(numbers, min_range, max_range)}");