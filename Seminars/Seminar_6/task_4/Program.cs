
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
PrintArray(CopyArray(numbers));
DuoPrintArray(DuoCopyArray(numbers));

double[] CopyArray(double[] array_copy)
{
    double [] copy_arr = new double [array_copy.Length];
    for (int i = 0; i < array_copy.Length; i++)
    {
        copy_arr[i]= array_copy[i];
    }
    return copy_arr;
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
void FillArray(double[] array)
{
    for(int i = 0; i< array.Length; i++)
    {
        array[i] = random.NextDouble();
    }
}

double[,] DuoCopyArray(double[] array_copy)
{
    double [,] copy_arr = new double [2,array_copy.Length];
    for (int i = 0; i < array_copy.Length; i++)
    {
        copy_arr[0, i]= array_copy[i];
        copy_arr[1, i]= i + 1;
    }
    
    return copy_arr;
}
void DuoPrintArray(double[,] array)
{
    Console.WriteLine();
    for(int i = 0; i< 1; i++)
    {

        for (int j = 0; j < array.Length-1; j++)
        {
           Console.Write($"{array[i,j]} "); 
        }
    }
    Console.WriteLine();
}