//Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы. 
//В случае, если это невозможно, программа должна вывести сообщение для пользователя.
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
if (CheckForSquarenessMatrix(m,n))
{
    int [,] array = CreateRandom2DArray(m,n);
    Print2Darray(array);
    Console.WriteLine("Change array-Matrix ");
    Print2Darray(ReplacementRowsVsColumns(array)); 
}
else
{
    Console.WriteLine("Matrix is't Squareness.Action can't be performed");
}



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
bool CheckForSquarenessMatrix(int num_m,int num_n)
{
    if(num_m != num_n)
    {
      return false;  
    }
    return true;
}
int[,] ReplacementRowsVsColumns(int[,] array)
{
    int count = array.GetLength(0);
    int[,] array_fresh= new int [count,count];
    for (int i = 0; i < count; i++)
    {
        for (int j = 0; j < count; j++)
        {
            array_fresh[i,j] = array[j,i];
        }  
    }
    return array_fresh;
}