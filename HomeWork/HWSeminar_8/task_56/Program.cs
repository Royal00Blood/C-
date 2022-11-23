// Задайте прямоугольный двумерный массив. Напишите метод, который будет находить строку с наименьшей суммой элементов.
Console.Write("Input m--> ");
bool isParsed_1 = int.TryParse(Console.ReadLine(),out int m);
Console.Write("Input n--> ");
bool isParsed_2 = int.TryParse(Console.ReadLine(),out int n);
Console.WriteLine($"Array {m} x {n}:");
if(!isParsed_1 || !isParsed_2)
{
    Console.WriteLine("Error");
    return;
}

int [,] array = CreateRandom2DArray(m,n);
Print2Darray(array);
Console.WriteLine($" Min sum element in row {FindMinRowSum(SumElementOnRow(array))+1}");

int[,] CreateRandom2DArray(int num_m, int num_n)
{
    int[,] array = new int [num_m, num_n];
    Random random = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i,j] = random.Next(1,10);
        }
    }
    return array;
}
void Print2Darray(int [,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i,j]} ");
        }
        Console.WriteLine();
    }
}
int [] SumElementOnRow(int[,]array)
{
    int [] max_elements_row = new int [array.GetLength(0)];
    int sum = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
          sum += array[i,j];
        }
        max_elements_row[i] = sum;
        sum = 0;
    }
    return max_elements_row;
}
int FindMinRowSum(int []array)
{
    int index_row = 0;
    int number = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (number > array[i])
        {
            number = array[i];
            index_row = i;
        }
    }
    return index_row;
}