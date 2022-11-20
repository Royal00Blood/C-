//Составить частотный словарь элементов двумерного массива. 
//Частотный словарь содержит информацию о том, сколько раз встречается элемент входных данных.
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
int[,] array_unique = GetUniqueArray(array);
Console.WriteLine();
Print2Darray(CutArray(array_unique));


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
int[,] GetUniqueArray(int[,]array)
{
    int[,] result = new int[2, array.Length];
    int index = 0;
    for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                if(CheckNumberInArray(result,array[i,j]) == false)
                {
                    result[0, index] = array[i,j];
                    result[1,index] = CountElement(array,array[i,j]);
                    index++;
                    
                }   
            }
        }
    return result;
}
bool CheckNumberInArray(int[,]array,int number)
{
    for (int i = 0; i < array.GetLength(1); i++)
    {
        if(array[0,i]==number)
        {
            return true;
        }
    }
    return false;
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
void PrintArray(int[] array)
{
    Console.WriteLine();
    for(int i = 0; i< array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
int CountElement(int [,]array,int element)
{
    int count = 0;
    for (int  i= 0;  i< array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if(array[i,j]==element)
            {
                count++;
            }
        }
    }
    return count;
}
int [,] CutArray(int[,]array)
{
    int index = array.GetLength(1)-1;
    for (int i = 0; i < array.GetLength(1); i++)
    {
        if (array[1,i] == 0)
        {
            index = i;
            break;
        }
    }
    int [,] result = new int[2,index];
    for (int i = 0; i < result.GetLength(1); i++)
    {
        result[0,i] = array[0,i];
        result[1,i] = array[1,i];
    }
    return result;
}