//возврашает значение элемента на позиции или что его нет
Console.Write("Input m--> ");
bool isParsed_1 = int.TryParse(Console.ReadLine(),out int number_m);
Console.Write("Input n--> ");
bool isParsed_2 = int.TryParse(Console.ReadLine(),out int number_n);
Console.WriteLine($"Array element {number_m} x {number_n}:");
if(!isParsed_1 || !isParsed_2)
{
    Console.WriteLine("Error");
    return;
}

int [,] array = CreateRandom2DArray();

if(CheckElementArray(number_m, number_n, array))
{
    Console.WriteLine(array[number_m, number_n]);
}
Print2Darray(array);

int[,] CreateRandom2DArray()
{
    Random random = new Random();
    int i_count = random.Next(3,20);
    int j_count = random.Next(3,20);
    int[,] array = new int[i_count, j_count];
    for (int i = 0; i < i_count; i++)
    {
        for (int j = 0; j < j_count; j++)
        {
            array[i,j] = random.Next(1,15);
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
bool CheckElementArray(int m,int n,int[,] array)
{
    int number= 0;
    if(m <= array.GetLength(0))
    {
        if(n <= array.GetLength(1))
        {
           return true;
        }
        else
        {
            Console.WriteLine($"Index {n} out of range");
            return false;
        }
    }
    else
        {
            Console.WriteLine($"Index {m} out of range");
            return false;
        }
    
}