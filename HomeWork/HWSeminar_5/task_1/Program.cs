// The number of even numbers in the array

Random random = new Random();
Console.Write("Input min number for lenght array ");
bool is_parsed = int.TryParse(Console.ReadLine(),out int min_range);
Console.Write("Input max number for lenght array ");
bool is_parsed_2 = int.TryParse(Console.ReadLine(),out int max_range);
int num =  random.Next(min_range, max_range);
Console.Write($"An array is created from {num} numbers:");
int[] numbers = new int[num];

FillArray(numbers);
PrintArray(numbers);
Console.WriteLine($"The number of even numbers in the array = {CountNumber(numbers)}");

void FillArray(int[] array)
{
    for(int i = 0; i< array.Length; i++)
    {
        array[i] = random.Next(100,999);
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
int CountNumber(int[] array)
{
    int count = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] % 2 == 0)
        {
            count+=1;
        }
    }
    return count;
}