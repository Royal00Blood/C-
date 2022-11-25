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
Print2Darray(SortedElementOnRow(array));

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
int [,] SortedElementOnRow(int[,]array)
{
        for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int i1 = 0; i1 < array.GetLength(1); i1++)
                {
                //Вложенный цикл (количество повторений, равно количеству элементов массива минус 1 и минус количество выполненных повторений основного цикла)
                    for (int j = 0; j < array.GetLength(1) - 1 - i1; j++)
                    {
                    //Если элемент массива с индексом j больше следующего за ним элемента
                        if (array[i,j] < array[i,j + 1])
                        {
                        //Меняем местами элемент массива с индексом j и следующий за ним
                            Swap(ref array[i,j], ref array[i, j + 1]);
                        }
                    }
                }
            }
    
    return array;
}
void Swap(ref int aFirstArg, ref int aSecondArg)
        {
            //Временная (вспомогательная) переменная, хранит значение первого элемента
            int tmpParam = aFirstArg;
            //Первый аргумент получил значение второго
            aFirstArg = aSecondArg;
            //Второй аргумент, получил сохраненное ранее значение первого
            aSecondArg = tmpParam;
        }


