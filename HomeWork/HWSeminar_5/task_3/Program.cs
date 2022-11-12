// task 3 difference between max and min array element

Random random = new Random();
Console.Write("Input min number for lenght array ");
bool is_parsed = int.TryParse(Console.ReadLine(),out int min_range);
Console.Write("Input max number for lenght array ");
bool is_parsed_2 = int.TryParse(Console.ReadLine(),out int max_range);
int num =  random.Next(min_range, max_range);
Console.Write($"An array is created from {num} numbers:");
double[] numbers = new double[num];

FillArray(numbers);
PrintArray(numbers);
Console.WriteLine($"Difference between max and min array element = {DifNumber(FindMin(numbers),FindMax(numbers))}");

void FillArray(double[] array)
{
    for(int i = 0; i< array.Length; i++)
    {
        array[i] = random.NextDouble();
    }
}
void PrintArray(double[] array)
{
    Console.WriteLine();
    for(int i = 0; i< array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
double DifNumber(double number_min,double number_max)
{
    return number_max - number_min;
}
double FindMin(double[] array)
{
    double min_num = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (min_num > array[i])
        {
            min_num = array[i];
        }
    }
    return min_num;
}
double FindMax(double[] array)
{
    double max_num = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (max_num < array[i])
        {
            max_num = array[i];
        }
    }
    return max_num;
}