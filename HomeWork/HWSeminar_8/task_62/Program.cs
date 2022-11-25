/*
Напишите метод, который заполнит спирально массив 
4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07
*/
Console.Write("Input count row in matrix-> ");
bool isParsed_1 = int.TryParse(Console.ReadLine(),out int a);

Print2Darray(Print2DarraySpiral(a));
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
int [,] Print2DarraySpiral(int n)
{
    var result = new int[n, n];
            for (int currentChar = 1, padding = 0; padding < n/2; padding++)
            {
                for (int j = padding; j < n - padding; j++)
                    result[padding, j] = currentChar;
                for (int j = padding; j < n - padding; j++)
                    result[n - padding - 1, j] = currentChar;
                for (int i = padding + 2; i < n - padding - 1; i++)
                    result[i, padding] = currentChar;
                for (int i = padding + 1; i < n - padding - 1; i++)
                    result[i, n - padding - 1] = currentChar;
                currentChar = 1 - currentChar;
                result[padding + 1, padding] = currentChar;
            }
            if (n%2 != 0 && result[0, 0] == 1)
                result[n/2, n/2] = 1;
            return result;
}