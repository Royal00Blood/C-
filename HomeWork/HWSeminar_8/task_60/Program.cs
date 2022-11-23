/*
Сформируйте трёхмерный массив из неповторяющихся 
двузначных чисел. Напишите метод, 
который будет построчно выводить массив, 
добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1)
*/
Console.Write("Input m--> ");
bool isParsed_1 = int.TryParse(Console.ReadLine(),out int m);
Console.Write("Input n--> ");
bool isParsed_2 = int.TryParse(Console.ReadLine(),out int n);
Console.Write("Input a--> ");
bool isParsed_3 = int.TryParse(Console.ReadLine(),out int a);
if(!isParsed_1 || !isParsed_2 || !isParsed_3)
{
    Console.WriteLine("Error");
    return;
}

int [,,] array = CreateRandom3DArray(m,n,a);
Print3Darray(array);


int[ , , ] CreateRandom3DArray(int num_m, int num_n,int num_a)
{
    int [] randNumber = new int [num_m * num_n * num_a];
    int[ , , ] array = new int [num_m, num_n, num_a];
    
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                 array[i,j,k] = NewRandomNumber(randNumber);
            }
        }
    }
    return array;
}
void Print3Darray(int [,,] array)
{
    Console.WriteLine();
    Console.WriteLine($"Array size {array.GetLength(0)} X {array.GetLength(1)} X {array.GetLength(2)} ");
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
               Console.Write($"{array[i,j,k]}({i},{j},{k}) "); 
            }
            
        }
        Console.WriteLine();
    }
}
int NewRandomNumber(int [] array)
{   
    int number = 0;
    Random random = new Random();
    while(true)
    {   
        number = random.Next(10,99);  
        for (int i = 0; i < array.Length; i++)
        {
            if(number == array[i])
            {
                number = -1;
            }
        }
        if (number != -1)
        {
            return number;
        }
    }
}