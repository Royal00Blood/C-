/*
Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22
2, 3, 2 -> 2
*/
Console.Write("Enter number of numbers->");
int[] array = new int [Convert.ToInt32(Console.ReadLine())];

for (int i=0; i < array.Length; i++)
    {
        Console.Write("Input number_"+ (i+1) + "=");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }

int max =  array[0];

for (int i = 0; i < array.Length; i++)
    {
        if(array[i] > max) max = array[i]; 
    }

Console.WriteLine(max); 