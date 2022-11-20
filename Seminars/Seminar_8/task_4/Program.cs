//Задайте двумерный массив из целых чисел. 
//Напишите программу, которая удалит строку и столбец, 
//на пересечении которых расположен наименьший элемент массива.
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
Print2Darray(DelRowAndColomn(FindIndexMinElement(array),array));

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
int [] FindIndexMinElement(int[,]array)
{
    int [] array_index = new int [2];
    int min_number = array[0,0];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if( min_number > array[i,j])
            {
                min_number = array[i,j];
                array_index[0] = i;
                array_index[1] = j;
            }
        }
    }
    return array_index;
}
int [,] DelRowAndColomn(int [] index_array,int[,]array)
{
    int index_i = 0;
    int index_j = 0;
    int [,] new_array = new int [array.GetLength(0)-1, array.GetLength(1)-1];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        if(i != index_array[0])
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                if(j != index_array[1])
                {
                    new_array[index_i,index_j] = array[i,j];
                    index_j++;
                }
            }
            index_j = 0;
            index_i++;
        }
        
    }
    return new_array;
}
