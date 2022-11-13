

/*Демонстрация решения
Задача 39: Напишите программу,
 которая перевернёт одномерный массив (последний элемент будет на 
 первом месте, а первый - на последнем и т.д.)
[1 2 3 4 5] -> [5 4 3 2 1]
[6 7 3 6] -> [6 3 7 6]*/

string[] array = new string[3]{ "Vitalya" , "Vasya" , "Ivan"};

//string[] reversedArray = ReverseArray(array);
PrintArray(array);
ReverseArray(array);
Console.WriteLine();
PrintArray(array);

void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
}
/*void ReverseArray(string[] array)
{
    for (var i = 0; i < array.Length; i++)
    {
        string tmp = array[i];
        array[i] = array[array.Length - 1 - i];
        array[array.Length - 1 - i] = tmp;
    }
    return reversed;
}
*/
string[] ReverseArray(string[] array)
{
    string[] reversed = new string[array.Length];

    for (var i = 0; i < array.Length; i++)
    {
        reversed[i] = array[array.Length - 1 - i];
    }

    return reversed;
}
