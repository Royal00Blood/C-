//Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.
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
Console.WriteLine();
Print2Darray(FreshArray(array));


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
int[,] FreshArray(int[,] array)
{
    int a = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        a = array[0,i];
        array[0,i] = array[array.GetLength(1)-1,i];
        array[array.GetLength(1)-1,i] = a;
    }
    return array;
}