/*
Задача 2: Напишите программу, 
которая на вход принимает два числа и выдаёт, 
какое число большее, а какое меньшее.
a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3
a = 1 b = 1 -> числа равны.
*/

int number_1 = Convert.ToInt32(Console.ReadLine());
int number_2 = Convert.ToInt32(Console.ReadLine());

if (number_1 > number_2)
    {
        Console.Write("max = ");
        Console.Write(number_1);
        Console.Write("__");
        Console.Write("min = ");
        Console.Write(number_2);
        Console.Write("__");
    }
else
    {
        if(number_1 == number_2)
            {
                Console.Write("The numbers are equal");
                Console.Write("__");
            }
        else
            {
                Console.Write("max = ");
                Console.Write(number_2);
                Console.Write("__");
                Console.Write("min = ");
                Console.Write(number_1);
                Console.Write("__");
            }
    }