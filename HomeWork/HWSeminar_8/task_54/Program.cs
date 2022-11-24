// Задайте двумерный массив. Напишите метод, который упорядочит по убыванию элементы каждой строки двумерного массива. 
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
Print2Darray(SortedRowInArray(array,FindMaxElementOnRow(array)));

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
int [] FindMaxElementOnRow(int[,]array)
{
    int [] max_elements_row = new int [array.GetLength(0)];
    int max_element = array[0,0];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if( max_element < array[i,j])
            {
                max_element = array[i,j];
            }
        }
        max_elements_row[i] = max_element;
    }
    return max_elements_row;
}
int[,] SortedRowInArray(int[,] array, int [] max_array_in_row)
{
    int [,] array_rez = new int [array.GetLength(0),array.GetLength(1)];
    int j_index = 0;
    //int [] array_1 = new int [array.GetLength(1)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        array_rez[i,0] = max_array_in_row[i];

        for (int j = 1; j < array.GetLength(1); j++)
        {
            for (int k = j; k < array.GetLength(1); k++)
            {
                if (array_rez[i,j-1] < array[i,j])
                {
                    j_index = j;
                }  
            }
            array_rez[i,j] = array[i,j_index];
        }
    }
    return array_rez;
}

